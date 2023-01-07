using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class SMSService : ISender
    {
        public void Send(Customer customer, string message)
        {
            Console.WriteLine($"Mensaje enviado a {customer.Name} por sms.");
        }
    }
}
