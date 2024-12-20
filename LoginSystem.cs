using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    internal class LoginSystem
    {
        public static void Login()
        {
            string user = "Piyush";
            string pass = "P@987";

            int count = 0;
            int maxCount = 3;

            while (count < maxCount)
            {
                Console.WriteLine("Enter Username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (username.Equals(user) && password.Equals(pass))
                {
                    Console.WriteLine("Login Success!!!");
                    return;
                }
                else if (!username.Equals(user)){
                    Console.WriteLine("Wrong Username!");
                }
                else if (!password.Equals(pass)){
                    Console.WriteLine("Wrong Password!");
                }
                else
                {
                    Console.WriteLine("Both username & password is incorrect.");
                }
                count++;
                Console.WriteLine("Only " + (maxCount - count) + " attempt left!");
            }

            Console.WriteLine("Account Locked!");
            
        }
    }
}
