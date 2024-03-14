using MongoDB.Driver;
using System.Data;

namespace AutoManager.Connection.Abstractions.Interfaces
{
    public interface IFactoryConnection
    {
        IDbConnection GetConnectionSql();
        IMongoClient GetConnectionNoSql();
    }
}
