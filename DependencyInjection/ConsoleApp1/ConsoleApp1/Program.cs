using ConsoleApp1.Repositories;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new OracleConnection();

            var repository = new CustomerRepository(connection);

            var customerService = new CustomerService(repository);

            var sender = new EmailService();

            var communicationService = new CommunicationService(sender);

            var customers = customerService.GetCustomers();

            var message = "Mensaje enviado a todos los clientes.";

            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer, message);
            }

        }
    }
}
