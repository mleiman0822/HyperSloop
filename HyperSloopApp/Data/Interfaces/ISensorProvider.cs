using HyperSloopApp.Data;
using HyperSloopApp.Models;

namespace HyperSloopApp.Data.Providers
{
    public interface ISensorProvider
    {
        Sensors Get(int SensorId);
    }
}