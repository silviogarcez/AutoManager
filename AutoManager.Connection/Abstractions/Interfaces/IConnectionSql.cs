using System.Data;

namespace AutoManager.Connection.Abstractions.Interfaces
{
    public interface IConnectionSql : IConnection
    {
        int ExecuteQuery(string query);
        IDataReader GetQuery(string query);
        IDbConnection GetConnection();
    }
}
