using AutoManager.Connection.Abstractions.Interfaces;
using AutoManager.Connection.Enums;
using System.Data;

namespace AutoManager.Connection.Abstractions
{
    public abstract class EngineConnectionSql : IConnectionSql
    {
        private IDbConnection _connection { set; get; }
        private IDbCommand _command;
        private readonly ConnectionType connectionType;

        //private IDbTransaction transacoes abstraidas
        //private IDbDataParameter caso queira passar os parametros abstraidos (SqlParameter ou OracleParameter)

        public EngineConnectionSql(IDbConnection connection, ConnectionType connectionType)
        {
            _connection = connection;
            this.connectionType = connectionType;
        }

        public void Close()
        {
            _connection.Close();
        }

        public void Open()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                Close();
            }

            _connection.Open();
        }

        public int ExecuteQuery(string query)
        {
            object ret;
            try
            {
                _command = _connection.CreateCommand();
                _command.CommandText = query;
                ret = _command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Convert.ToInt32(ret);
        }

        public IDataReader GetQuery(string query)
        {
            IDataReader ret = null;
            try
            {
                _command = _connection.CreateCommand();
                _command.CommandText = query;
                ret = _command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ret;
        }

        public IDbConnection GetConnection()
        {
            return _connection;
        }

        public ConnectionType CurrentDB()
        {
            return connectionType;
        }
    }
}
