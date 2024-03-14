using AutoManager.Connection.Abstractions;
using AutoManager.Connection.Enums;

namespace AutoManager.Connection
{
    public class ConnectionSql : EngineConnectionSql
    {
        public ConnectionSql(ConnectionType connectionType, string connectionString) : base(new FactoryConnection(connectionType, connectionString).GetConnectionSql(), connectionType)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("String de conexao vazia", nameof(connectionString));
            }
        }
    }
}