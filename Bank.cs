using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Bank
    {
        public Client[] Clients { get; set; }

        public Bank(Client[] clients)
        {
            Clients = clients;
        }

        public Client ShowAtm(string pin)
        {
            foreach (Client client in Clients)
            {
                if (client.Card.PIN == pin)
                {
                    return client;
                }
            }

            return null;
        }
    }
}
