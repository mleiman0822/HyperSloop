using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyperSloopApp.Data;
using HyperSloopApp.Services;
using Microsoft.AspNetCore.Components;

namespace HyperSloopApp.Data
{
    public class SlideUploadService 
    {
        [Inject]
        public ApplicationDbContext appDbContext { get; set; }
        public Dictionary<int, SlideData> SlideData { get; set; }
        //public UDPService UDPService = new UDPService("127.888.888", 3306, 8377);
        public SlideUploadService()
        {
            //Instantiate the buckets 
            //recreate udpservce in data folder, blazor still thinks services folder exists 
            SlideData = new Dictionary<int, SlideData>();
            //instantiate the new slides based on info from query to the database 
            //var slides = appDbContext.Slides;
            //foreach(var slide in slides)
            //{
            //    SlideData.Add(slide.SlideId, new SlideData());
            //}
        }

        public void SetUser(int SlideId, string email)
        {
            SlideData[SlideId].Email = email;
        }
        public void StartTime(int SlideId, DateTime startTime)
        {
            SlideData[SlideId].StartTime = startTime;
        }
        public void EndTime(int SlideId, DateTime endTime)
        {
            SlideData[SlideId].EndTime = endTime;
            SlideData[SlideId].Validate();
        }
    }
}
