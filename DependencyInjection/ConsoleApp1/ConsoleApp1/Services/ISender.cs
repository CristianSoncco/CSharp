using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public interface ISender
    {
        void Send(Customer customer, string message);
    }
}
