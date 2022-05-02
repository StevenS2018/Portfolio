using System;
using BankApplication;
using System.Collections.Generic;

namespace BankApplication
{


    internal class Program
    {

        private static void Main(string[] args)
        {
            string newPassword = "";
            
            string password = CreatePassword(newPassword);

            PrintMessage(password);
        }
        private static void PrintMessage(string password)
        {
            Console.WriteLine($"Your new Password Is: {password}");
        }

        private static string CreatePassword(string password)
        {
            string newPassword = "Hello";
            
            if (newPassword != password)
            {
                Console.WriteLine($"Please create your password: {newPassword}");
            }

            string confirmPassword = newPassword;

            if (confirmPassword == newPassword)
            {
                Console.WriteLine($"Please Confirm Your Password: {confirmPassword}");
                password = newPassword;
                
            }
            return password;
            
        }
    }
}
