using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

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

            //Console.WriteLine(IsPhoneNumber(number));

            if (IsPhoneNumber(number) == true)
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Phone number is not valid!");
            }
            Console.WriteLine();

            //Checking date validiity
            Console.WriteLine("Please enter a valid date: ");
            string tempDate = Console.ReadLine();

           // Console.WriteLine(IsDate(tempDate));

            if (IsDate(tempDate) == true)
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Date is not valid!");
            }
            
        }

        //Method to check if date is in the format : mm/dd/yyyy
        public static bool IsDate(string tempDate)
        {
            if (Regex.IsMatch(tempDate, @"(\d{2})/(\d{2})/(\d{4})"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Method to check if phone number is in format xxx-xxx-xxxx
        public static Boolean IsPhoneNumber(string number)
        {
            if (Regex.Match(number, @"(\d{3})-(\d{3})-(\d{4})").Success)
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
