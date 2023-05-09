using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<AccountModel>>(myJsonResponse);
    public class Account
    {
        [JsonProperty("Id")]
        public int Id;

        [JsonProperty("AccountName")]
        public string AccountName;

        [JsonProperty("Balance")]
        public double Balance;

        [JsonProperty("Username")]
        public string Username;

        public static void DisplayAccountList()
        {
            var accountList = new List<Account>();
            var accountJson = File.ReadAllText(@"D:\Practice\ConsoleBank\ConsoleBank\Accounts.json");
            var accounts = JsonConvert.DeserializeObject<Account[]>(accountJson);
            Console.WriteLine("\n\tAccounts");
            foreach (var account in accounts) Console.WriteLine($"{account.AccountName}:{account.Balance}\n");
        }
    }
}

