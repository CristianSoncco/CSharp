using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repositories
{
    public interface IRepository
    {
        List<Customer> GetCustomers();
    }
}
