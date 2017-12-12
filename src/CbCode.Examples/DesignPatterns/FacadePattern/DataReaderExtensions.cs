using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public static class DataReaderExtensions
    {
        public static T MapTo<T>(this IDataReader dataReader)
        {
            var type = typeof(T);

            var properties = type.GetProperties().Where(p => p.GetCustomAttribute(typeof(DbFieldAttribute)) != null);
            var instance = (T)Activator.CreateInstance(type, true);

            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<DbFieldAttribute>();
                property.SetValue(instance, dataReader[attr.Name]);
            }

            return instance;
        }
    }
}