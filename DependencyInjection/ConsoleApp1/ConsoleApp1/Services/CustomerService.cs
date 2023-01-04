using ConsoleApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
    }
}
