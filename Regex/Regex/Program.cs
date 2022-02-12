using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegexAss
{
    public class Program
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter the name");
            string firstName = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            //foreach (string str in firstName)
            //{
            //    bool regrex =Regex.IsMatch(str, pattern);
            //    if(regrex)
            //        Console.WriteLine("{0} is valid",str);
            //    else
            //        Console.WriteLine("{0} is Invalid",str);
            //}
            if (Regex.IsMatch(firstName, pattern))
                Console.WriteLine("entered name is valid");
            else
            {
                Console.WriteLine("Entered name is Invalid\n please give first character in capital and minimum 3 characters name");
                ValidFirstName();
            }

        }
        public static void ValidLastName()
        {
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            string pattern = "(^[^a-z][A-z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lastName, pattern))
                Console.WriteLine("entered name is valid");
            else
            {
                Console.WriteLine("Entered name is Invalid\n for valid name please give first character in capital and give minimum 3 character");
                ValidLastName();
            }
        }
        public static void ValidEmail()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            string pattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("entered email is valid");
                Nlog.SuccessLog("Entered mail is valid  "+ email);
                ValidEmail();
            }
            else
            {
                Console.WriteLine("entered email invalid");
                Nlog.ErrorInfo("Entered mail not valid  "+ email);
                ValidEmail();
            }
        }

        public static void ValidMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();
            string pattern = "^91[ ][0-9]{10}$";
            if (Regex.IsMatch(mobileNumber, pattern))
                Console.WriteLine("Mobile Number is Valid");
            else
            {
                Console.WriteLine("Not Valid Mobile Number");
                ValidMobileNumber();
            }
        }
        public static void ValidPassword()
        {
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            string pattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Password valid");
                ValidPassword();
            }
            else
            {
                Console.WriteLine("Invalid Password");
                ValidPassword();
            }
        }
        public static void ValidPin()
        {
            Console.WriteLine("Enter postal pin");
            string postalPin = Console.ReadLine();
            string pattern = "^[0-9]{3}[ ][0-9]{3}";
            if (Regex.IsMatch(postalPin, pattern))
                Console.WriteLine("Valid pin");
            else
            {
                Console.WriteLine("Invalid postal pin");
                ValidPin();
            }
        }
        static void Main(string[] args)
        {
            //UC1
            //ValidFirstName();
            //UC2
            //ValidLastName();
            //UC3
            ValidEmail();
            //UC4
            //ValidMobileNumber();
            //UC5
            //ValidPassword();

            //ValidPin();

            Console.ReadLine();
        }
    }
}
