using ConsoleApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class CustomerService
    {
        private IRepository _repository;
        private IDbConnection _connection = new OracleConnection();

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
