using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public AccountModel(int id, string name, int balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        public void PrintAccount()
        {
            Console.WriteLine($"{Name}:{Balance}");
        }
    }
}

