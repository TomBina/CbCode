
using System.Data.Common;
using System.Data.SqlClient;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public class Database
    {
        private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=CbCode;Trusted_Connection=True;Connection Timeout=1";

        public static DbConnection CreateConnection() => 
            new SqlConnection(ConnectionString);
    }

    public static class DbConnectionExtensions
    {
        public static DbCommand CreateCommand(this DbConnection connection, string commandText)
        {
            var dbCommand = connection.CreateCommand();
            dbCommand.CommandText = commandText;

            return dbCommand;
        }
    }

    public static class DbParameterCollectionExtensions
    {
        public static DbParameterCollection AddRange(this DbParameterCollection collection, params object[] values)
        {
            collection.AddRange(values);

            return collection;
        }
    }
}