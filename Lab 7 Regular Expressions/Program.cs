using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Lab_7_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name: ");
            string name = Console.ReadLine();

           // Console.WriteLine(IsAlpha(name));

            //Checking validity of letters
            if (IsAlpha(name) == true)
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid");
            }

            Console.WriteLine();
           
            //Checking validity of email
            Console.WriteLine("Please enter a valid email");
            string email = Console.ReadLine();

            if (IsValidEmail(email)== true)
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }
            Console.WriteLine();

            //Checking phone number validity
            Console.WriteLine("Enter a valid phone number: ");
            string number = Console.ReadLine();

            Console.WriteLine(IsPhoneNumber(number));

            if (IsPhoneNumber(number) == true)
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Phone number is not valid!");
            }
            
            
        }

        // Write a method that will validate phone numbers. A phone number should
        // be in the following format: {area code of 3 digits} - {3 digits} - {4 digits}

        public static Boolean IsPhoneNumber(string number)
        {
            if (Regex.Match(number, @"^(\+[0-9]{10})$").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Names can only have alphabets, they should start with a capital letter, 
        //and they have a maximum length of 30.
        public static Boolean IsAlpha(string name)
        {
            

            if (Regex.IsMatch(name, @"^[a-z A-Z]{1,30}$"))
            {
                return true;
              
            }
            else 
            {
                return false;
              
                
            }
        }

        public static Boolean IsValidEmail (string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
