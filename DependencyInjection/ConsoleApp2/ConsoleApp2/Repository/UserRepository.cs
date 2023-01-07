using ConsoleApp2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Repository
{
    public class UserRepository : IRepository
    {
        public List<User> GetUsers()
        {
            return new List<User>();

        }
    }
}
