using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.
Print the data at the console.
*/


namespace EmployeeDataProblemTen
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Chicho";
            string LastName = "Skruch";
            byte age = 100;
            char gender = 'm';
            ulong IDnumber = 8012207408;
            uint employeeNumber = 27569999;
            Console.WriteLine("My first name is \"{0}\" and my last name is \"{1}\". I am old as hell, beacuse I am {2} years old and my gander is \"{3}ale\". My ID number is:{4} and my employee number is:{5}"
                ,firstName,LastName,age,gender,IDnumber,employeeNumber);


        }
    }
}
