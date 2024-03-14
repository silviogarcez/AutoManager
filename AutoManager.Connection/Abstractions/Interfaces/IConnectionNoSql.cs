using MongoDB.Driver;

namespace AutoManager.Connection.Abstractions.Interfaces
{
    public interface IConnectionNoSql : IConnection
    {
        IMongoClient GetConnection();
    }
}
