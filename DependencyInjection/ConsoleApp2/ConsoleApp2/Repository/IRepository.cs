using ConsoleApp2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Repository
{
    public interface IRepository
    {
        List<User> GetUsers();
    }
}
