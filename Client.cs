using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public BankCard Card { get; set; }
    }
}