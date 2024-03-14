using AutoManager.Connection.Abstractions.Interfaces;
using AutoManager.Connection.Enums;
using MongoDB.Driver;
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;

namespace AutoManager.Connection
{
    internal class FactoryConnection : IFactoryConnection
    {
        private readonly IDbConnection connection;

        private readonly IMongoClient connectionNoSql;

        private readonly ConnectionType connectionType;

        public FactoryConnection(ConnectionType connectionType, string connectionString)
        {
            switch (connectionType)
            {
                case ConnectionType.SQL:
                    connection = new SqlConnection(connectionString);
                    break;
                case ConnectionType.ORACLE:
                    connection = new OracleConnection(connectionString);
                    break;
                case ConnectionType.POSTGRESQL:
                    connection = new NpgsqlConnection(connectionString);
                    break;
                case ConnectionType.MONGODB:
                    connectionNoSql = new MongoClient(connectionString);
                    break;
                default:
                    throw new Exception("Tipo de conexao invalido");
            }

            this.connectionType = connectionType;
        }

        public IDbConnection GetConnectionSql()
        {
            return connectionType != ConnectionType.MONGODB ? connection : throw new Exception("ConnectionType is wrong");
        }

        public IMongoClient GetConnectionNoSql()
        {
            return connectionType == ConnectionType.MONGODB ? connectionNoSql : throw new Exception("ConnectionType is wrong");
        }
    }
}
