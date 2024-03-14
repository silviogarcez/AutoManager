using AutoManager.Connection.Enums;
using System.Data;

namespace AutoManager.Connection.Abstractions.Interfaces
{
    public interface IConnection
    {        
        ConnectionType CurrentDB();
    }
}
