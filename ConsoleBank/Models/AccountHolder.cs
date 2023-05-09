using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleBank.Models
{
    public class AccountHolder
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("first_name")]
        public string FirstName;

        [JsonProperty("last_name")]
        public string LastName;

        [JsonProperty("username")]
        public string Username;

        [JsonProperty("email")]
        public string Email;

        public static void DisplayUserList()
        {
            var userList = new List<AccountHolder>();
            var userJson = File.ReadAllText(@"D:\Practice\ConsoleBank\ConsoleBank\Users.json");
            var users = JsonConvert.DeserializeObject<AccountHolder[]>(userJson);
            Console.WriteLine("\n\tUsers");
            foreach (var user in users) Console.WriteLine($"{user.Id}:{user.FirstName} {user.LastName}\n{user.Email}\n");
        }
    }
}
