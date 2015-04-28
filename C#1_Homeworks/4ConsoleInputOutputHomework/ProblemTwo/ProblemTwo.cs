using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

namespace ProblemTwo
{
    class PrintCompanyInformation
    {
        public static void rl()
        {
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name of the manager");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name of the manager");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter phone name of the manager");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter adress of the company");
            string adress = Console.ReadLine();
            Console.WriteLine("Enter fax number of the company");
            long faxNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter web page of the company");
            string webPage = Console.ReadLine();

            Console.WriteLine(@"The name of the manager is""{0} {1}"". His phone number is ""{2}"". The adress of the company is ""{3}"". The fax number of the company is ""{4}"". The web page  of the company is ""{5}"".", firstName, lastName, phoneNumber, adress, faxNumber, webPage);







        }
    }
}
