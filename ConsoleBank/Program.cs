using ConsoleBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleBank
{
    class Program 
    {
        static void Main(string[] args)
        {
            var userList = new List<AccountHolderModel>();
            var user1 = new AccountHolderModel(1, "steven");
            var user2 = new AccountHolderModel(2, "john");
            var user3 = new AccountHolderModel(3, "ralph");
            var user4 = new AccountHolderModel(4, "everette");
            var user5 = new AccountHolderModel(5, "james");
            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);
            userList.Add(user5);

            var myBank = new AccountModel(1, "Checking", 100);


            GetAllUsers(userList);
            myBank.PrintAccount();
        }
        static void GetAllUsers(List<AccountHolderModel> userList)
        {
            foreach (var user in userList) user.PrintUser();
        }
    }
    
    

}
