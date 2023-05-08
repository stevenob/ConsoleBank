using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Models
{
    internal class AccountHolderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AccountHolderModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PrintUser()
        {
            Console.WriteLine($"{Id}:{Name}");
        }
    }
}
