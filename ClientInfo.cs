using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Client
    {
        public void Show()
        {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Surname : " + Surname);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Salary : " + Salary);
        }
    }
}
