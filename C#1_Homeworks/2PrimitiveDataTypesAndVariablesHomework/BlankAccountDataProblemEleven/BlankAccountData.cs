using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/


namespace BlankAccountDataProblemEleven
{
    class BlankAccountData
    {
        static void Main(string[] args)
        {
            string firstName="Petar";
            string middleName="Petrov";
            string lastName="Petrov";
            decimal balanceOfMoney=55997885555555555555555555555m;
            string bankName="DSK";
            string iban = "NL91ABNA0417164300";
            ulong creditCardNumberOne=1234567891234567u;
            ulong creditCardNumberTwo=1234567891234566u;
            ulong creditCardNumberThree=1234567891234565u;
            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(balanceOfMoney);
            Console.WriteLine(bankName);
            Console.WriteLine(iban);
            Console.WriteLine(creditCardNumberOne);
            Console.WriteLine(creditCardNumberTwo);
            Console.WriteLine(creditCardNumberThree);
        
        }
    }
}
