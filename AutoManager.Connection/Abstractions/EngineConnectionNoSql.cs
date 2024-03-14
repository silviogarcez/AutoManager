using AutoManager.Connection.Abstractions.Interfaces;
using AutoManager.Connection.Enums;
using MongoDB.Driver;

namespace AutoManager.Connection.Abstractions
{
    public abstract class EngineConnectionNoSql : IConnectionNoSql
    {
        private readonly IMongoClient connection;
        private readonly ConnectionType connectionType;

        public EngineConnectionNoSql(IMongoClient connection, ConnectionType connectionType)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
            this.connectionType = connectionType;
        }

        public ConnectionType CurrentDB()
        {
            return connectionType;
        }

        public IMongoClient GetConnection()
        {
            return connection;
        }
    }
}
