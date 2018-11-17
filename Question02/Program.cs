using System;
using System.Collections.Generic;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine(" please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
{
                    break;
                }
                user.Add(userName);
                Console.WriteLine($"number of addedUser { user.GetUsersCount()}");
                
            }
        }

       

    }

    public class User
    {
        private static int UserCount = 0;

        
        public void Add(string username)
        {
            UserCount++;
        }

        public int GetUsersCount()
        {
            return UserCount;
        }
    }
}
