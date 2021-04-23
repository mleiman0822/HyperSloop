using HyperSloopApp.Data;
using HyperSloopApp.Models;

namespace HyperSloopApp.Data.Providers
{
    public interface IEventProvider
    {
        Events Get(int EventId);
    }
}