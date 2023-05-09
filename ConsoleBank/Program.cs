using ConsoleBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ConsoleBank
{
    class Program 
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("**********");
                Console.WriteLine("Display [A]ccounts or [U]sers?");
                char userInput = (char)Console.Read();

                switch (userInput.ToString().ToLower())
                {
                    case "a":
                        Account.DisplayAccountList();
                        Console.ReadLine();
                        goto default;
                    case "u":
                        AccountHolder.DisplayUserList();
                        Console.ReadLine();
                        goto default;
                    default:
                        Console.WriteLine("restarting...");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("**********");
            }
        }
    }
}
