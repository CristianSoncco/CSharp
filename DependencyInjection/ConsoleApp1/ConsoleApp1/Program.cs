using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var communicationService = new CommunicationService();

            var customers = customerService.GetCustomers();

            var message = "Mensaje enviado a todos los clientes.";

            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer, message);
            }

        }
    }
}
