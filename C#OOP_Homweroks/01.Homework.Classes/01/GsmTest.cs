using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

namespace Phones
{
    class GsmTest
    {

        static void Main()
        {
            //TEST GSM
            //add some phones
            GSM[] gsms =
            {
                new GSM("HTC 1","HTC Corp",439.99,"I am the onwer",new Battery(BatteryModel.NiCd,15.6,18),new Display(20,2560000)),
                new GSM("SamsungS4", "Samsung",300,"Me",new Battery(BatteryModel.NiMH,45,40)),
                new GSM("SamsungS3", "Samsung",500)
            };
            foreach (var gsm in gsms)
            {
               Console.WriteLine(gsm);
            }
            Console.WriteLine(GSM.Iphone4s);

            /*------------------------------------------------------------------------------------------------------*/

            //TEST CallHistory 
            //Add new phone
            GSM samsung = new GSM("samsung", "SamsungINC", 500);
            samsung.Price = 600;
            Console.WriteLine(samsung);
            GSM myPhone = new GSM("Iphone6", "Apple", 650.00, "AppleINC", new Battery(BatteryModel.NiCd, 10, 12), new Display(8, 256000000));
            //Add some calls
            myPhone.AddCall(new Call(new DateTime(2015,3,8,8,52,35), "+359883530522", 200));
            myPhone.AddCall(new Call(DateTime.Now, "+3598834320522", 130));
            myPhone.AddCall(new Call(DateTime.Now, "+3598833430522", 1300));
            myPhone.AddCall(new Call(DateTime.Now, "+359883530522", 200));

            //print info about calls
            foreach (var item in myPhone.CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The total price from all calls in history is: {0}$", myPhone.CalculatePrice(GSM.PRICE_PER_MINUTE));
            Console.WriteLine("------------------------------------------------------------------------");
            //Remove the longest call 
            int longestCallDuration = 0;
            int currentIndexOfMaxCallDuration = -1;
            for (int i = 0; i < myPhone.CallHistory.Count; i++)
            {
                if (myPhone.CallHistory[i].Seconds > longestCallDuration)
                {
                    longestCallDuration = myPhone.CallHistory[i].Seconds;
                    currentIndexOfMaxCallDuration = i;
                }
            }
            myPhone.RemoveCall(myPhone.CallHistory[currentIndexOfMaxCallDuration]);
            //print info about calls
            foreach (var item in myPhone.CallHistory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The total price from all calls in history is: {0}$", myPhone.CalculatePrice(GSM.PRICE_PER_MINUTE));
            Console.WriteLine("------------------------------------------------------------------------");
            myPhone.CallHistory.Clear();
            bool isEmpty = true;
            foreach (var item in myPhone.CallHistory)
            {
                Console.WriteLine(item);
                isEmpty = false;
            }
            if (isEmpty == true)
            {
                Console.WriteLine("The list with calls history is empty");
            }
        }
    }
}
