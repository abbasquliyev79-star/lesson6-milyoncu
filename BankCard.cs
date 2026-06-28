using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class BankCard
    {
        public string BankName { get; set; }
        public string UserName { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public string ExpireDate { get; set; }
        public double Balance { get; set; }
    }
}
