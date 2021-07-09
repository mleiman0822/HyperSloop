using HyperSloopApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HyperSloopApp.Models;
using Microsoft.Extensions.DependencyInjection;
using HyperSloopApp.Data;

namespace HyperSloopApp.Services
{
    public class UDPService
    {
        private int receivePort;
        private string serverIP;
        private IPEndPoint receiveEndPoint;
        private IServiceScopeFactory scopeFactory;

        [Serializable]
        private class SensorData
        {
            public string Id { get; set; }
            public string Distance { get; set; }
        }

        public UDPService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
            this.serverIP = "10.0.61.12";
            this.receivePort = 7321;
            this.receiveEndPoint = new IPEndPoint(IPAddress.Parse(this.serverIP), this.receivePort);
            this.MessageRecievedEvent += (x) => { MessageRecievedTask.SetResult(x); MessageRecievedTask = new TaskCompletionSource<string>(); };
            this.readerUdpClient();
        }

        void readerUdpClient()
        {
            new Thread(() =>
            {
                UdpClient readerClient = new UdpClient(receivePort);
                var remoteEP = new IPEndPoint(IPAddress.Any, 0);
                while(true)
                {
                    byte[] bytesReceived = readerClient.Receive(ref remoteEP);
                    //To do : Fix memory leak. 
                    var HandlerCount = MessageRecievedEvent.GetInvocationList().Length;
                    MessageRecievedEvent.Invoke(fromBytes(bytesReceived));
                    UploadSensorEvent(fromBytes(bytesReceived));
                }
            }).Start();

        }

        private TaskCompletionSource<string> MessageRecievedTask = new TaskCompletionSource<string>();
        public async Task<string> GetNext()
        {
            return await MessageRecievedTask.Task;
        }
        
        public event UDPEventHandler MessageRecievedEvent;

        public delegate void UDPEventHandler(string message);


        public byte[] toBytes(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public string fromBytes(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        //inserting sensor event into the database
        public void UploadSensorEvent(string message)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var _applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var deserializedMessage = JsonSerializer.Deserialize<SensorData>(message);
                var sensor = _applicationDbContext.Sensors.Where(x => x.ExternalDeviceId == deserializedMessage.Id).First();
                var rand = new Random();
                _applicationDbContext.SensorEvents.Add(new SensorEvent
                {
                    Sensor = sensor,
                    Time = DateTime.Now
                });
                _applicationDbContext.Events.Add(new Events
                {
                    DateTime = DateTime.Now,
                    EventType = sensor.EventType,
                    SlideId = sensor.SlideId,
                    Slide = sensor.Slide
                });
                _applicationDbContext.SaveChanges();
            }
        }
       
    }
}

