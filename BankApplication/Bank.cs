using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Bank
    {
        public string Name { get; set; }
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
    }
}
