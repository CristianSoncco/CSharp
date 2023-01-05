using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repositories
{
    public class CustomerRepository
    {
        private IDbConnection _connection;

        public CustomerRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public CustomerRepository()
        {
            _connection = new MySQLConnection();
        }
        public List<Customer> GetCustomers()
        {
            if (_connection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Obtenemos clientes desde MySQL");
            else if (_connection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Obtenemos clientes desde Oracle");

            return new List<Customer>
            {
                new Customer(){Id=1,Name="Papa Hut",Email="papa@gut.com",Phone="978465132"},
                new Customer(){Id=1,Name="Pep Col",Email="pep@col.com",Phone="978321456"}

            };
        }
    }
}
