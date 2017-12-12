using System.Data;
using System.Data.Common;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public static class DbCommandExtensions
    {
        public static DbParameter CreateParameter(this DbCommand command, string name, object value, DbType dbType)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = dbType;
            return parameter;
        }
    }
}