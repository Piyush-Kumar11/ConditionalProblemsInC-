using System;

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
                try
                {
                    Console.WriteLine("Enter Username: ");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter Password: ");
                    string password = Console.ReadLine();

                    if (!username.Equals(user))
                    {
                        throw new InvalidUsernameException();
                    }

                    if (!password.Equals(pass))
                    {
                        throw new InvalidPasswordException();
                    }

                    // If both username and password are correct
                    Console.WriteLine("Login Success!!!");
                    return;
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                count++;
                if (count < maxCount)
                {
                    Console.WriteLine("Only " + (maxCount - count) + " attempts left!");
                }
            }

            // If all attempts are used, lock the account
            try
            {
                throw new AccountLockedException();
            }
            catch(AccountLockedException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
