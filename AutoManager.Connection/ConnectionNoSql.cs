using AutoManager.Connection.Abstractions;
using AutoManager.Connection.Enums;

namespace AutoManager.Connection
{
    public class ConnectionNoSql : EngineConnectionNoSql
    {
        public ConnectionNoSql(ConnectionType connectionType, string connectionString) : base(new FactoryConnection(connectionType, connectionString).GetConnectionNoSql(), connectionType)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("String de conexao vazia", nameof(connectionString));
            }
        }
    }
}
