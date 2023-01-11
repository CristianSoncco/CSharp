using ConsoleApp2.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();

    }
}
