using ConsoleApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;
        private IDbConnection _connection = new OracleConnection();

        public CustomerService()
        {
            _repository = new CustomerRepository(_connection);
        }

        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
