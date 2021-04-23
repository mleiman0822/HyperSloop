using HyperSloopApp.Data;
using HyperSloopApp.Models;

namespace HyperSloopApp.Data.Providers
{
    public interface IUserProvider
    {
        User Get(int KeyCardId);
    }
}