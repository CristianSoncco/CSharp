using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class CommunicationService
    {
        private ISender _sender;
        public CommunicationService(ISender sender)
        {
            _sender = sender;
        }

        public void SendMessage(Customer customer,string message)
        {
            _sender.Send(customer,message);
        }
    }
}
