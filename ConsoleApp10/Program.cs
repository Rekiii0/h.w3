using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
       
        public UserAccount(string email, string username, string pass)
        {
            Email = email;
            Username = username;
            Pass = pass;
        }
        
        public UserAccount(UserAccount account)
        {
            Email = account.Email;
            Username = account.Username;
            Pass = account.Pass;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList accounts = new ArrayList();
            
            accounts.Add(new UserAccount("user1@example.com", "user1",
            "password1"));
            accounts.Add(new UserAccount("user2@example.com", "user2",
            "password2"));
            accounts.Add(new UserAccount("user3@example.com", "user3","password3"));
            
            Console.WriteLine("Enter Username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string inputPassword = Console.ReadLine();
            // Check for valid credentials
            bool isValid = false;
            foreach (UserAccount account in accounts)
            {
                if (account.Username == inputUsername && account.Pass
                == inputPassword)
                {
                    isValid = true;
                    break;
                }
            }
            // Display result
            if (isValid)
            {
                Console.WriteLine("Correct credentials!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }
            Console.ReadKey();
        }
    }


}
    

