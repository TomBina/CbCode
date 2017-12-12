using System;
using System.Data;
using System.Data.SqlClient;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public class CustomerService
    {
        private Database Database { get; }

        public CustomerService(Database database)
        {
            Database = database;
        }

        public int Add(string name, string email)
        {
            using (var connection = Database.CreateConnection())
            {
                var command = connection.CreateCommand("INSERT INTO Customers (Date, Name, Email) VALUES (@Date, @Name, @Email)");
                var dateParameter = command.CreateParameter("Date", DateTime.Now, DbType.DateTime2);
                var nameParameter = command.CreateParameter("Name", name, DbType.String);
                var emailParameter = command.CreateParameter("Email", email, DbType.String);

                command.Parameters.AddRange(dateParameter, nameParameter, emailParameter);

                try
                {
                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected;

                }
                catch (SqlException ex)
                {
                    if (ex.Number == -1)
                        throw new ApplicationException(
                            "No connection could be established with SQL server. To run this test run database.sql first.",
                            ex);
                    else
                        throw;
                }
            }
        }

        public Customer Get(int id)
        {
            using (var connection = Database.CreateConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT CustomerId, Date, Name, Email FROM Customers WHERE CustomerId = @CustomerId";

                var customerId = command.CreateParameter("CustomerId", id, DbType.Int32);
                command.Parameters.Add(customerId);

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return reader.MapTo<Customer>();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == -1)
                        throw new ApplicationException(
                            "No connection could be established with SQL server. To run this test run database.sql first.",
                            ex);
                    else
                        throw;
                }
            }

            return null;
        }
    }
}