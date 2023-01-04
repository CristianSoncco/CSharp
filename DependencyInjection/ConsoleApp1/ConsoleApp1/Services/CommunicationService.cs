using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class CommunicationService
    {
        private EmailService _emailService;
        public CommunicationService()
        {
            _emailService = new EmailService();
        }

        public void SendMessage(Customer customer,string message)
        {
            _emailService.Send(customer,message);
        }
    }
}
