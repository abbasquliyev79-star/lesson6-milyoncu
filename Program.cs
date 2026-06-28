using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Client client1 = new Client();
        client1.Id = 1;
        client1.Name = "Abbas";
        client1.Surname = "Quliyev";
        client1.Age = 20;
        client1.Salary = 1200;

        client1.Card = new BankCard();
        client1.Card.BankName = "Kapital Bank";
        client1.Card.UserName = "Abbas";
        client1.Card.PAN = "4169730012345678";
        client1.Card.PIN = "1111";
        client1.Card.CVC = random.Next(100, 1000).ToString();
        client1.Card.ExpireDate = "06/2028";
        client1.Card.Balance = random.Next(500, 5000);

        Client client2 = new Client();
        client2.Id = 2;
        client2.Name = "Ali";
        client2.Surname = "Memmedov";
        client2.Age = 25;
        client2.Salary = 1800;

        client2.Card = new BankCard();
        client2.Card.BankName = "ABB";
        client2.Card.UserName = "Ali";
        client2.Card.PAN = "4169730098765432";
        client2.Card.PIN = "2222";
        client2.Card.CVC = random.Next(100, 1000).ToString();
        client2.Card.ExpireDate = "10/2027";
        client2.Card.Balance = random.Next(500, 5000);

        Client[] clients =
        {
            client1,
            client2
        };

        Bank bank = new Bank(clients);

        while (true)
        {
            Console.Clear();

            Console.Write("PIN daxil edin : ");
            string pin = Console.ReadLine();

            Client currentClient = bank.ShowAtm(pin);

            if (currentClient == null)
            {
                Console.WriteLine("Bu PIN koda aid kart tapilmadi.");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            Console.WriteLine(currentClient.Name + " " + currentClient.Surname + " xos gelmisiniz");

            Console.WriteLine();
            Console.WriteLine("1. Balans");
            Console.WriteLine("2. Nagd pul");
            Console.WriteLine("3. Emeliyyatlar");
            Console.WriteLine("4. Kartdan karta kocurme");
            Console.WriteLine("5. Cixis");

            Console.Write("Secim : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Balans : " + currentClient.Card.Balance);
            }
            else if (choice == 5)
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Davam etmek ucun bir duymeye basin...");
            Console.ReadKey();
        }
    }
}