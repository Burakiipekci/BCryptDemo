using System;
using System.Security.Cryptography;

namespace BCryptDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password:");
            string password = Console.ReadLine(); 
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            Console.WriteLine("Password: " + password);   
            bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            if (isPasswordCorrect)
            {
                Console.WriteLine("Hashed Password => " + " "+BCrypt.Net.BCrypt.HashPassword(password));
            }
    
        }
    }
    }

