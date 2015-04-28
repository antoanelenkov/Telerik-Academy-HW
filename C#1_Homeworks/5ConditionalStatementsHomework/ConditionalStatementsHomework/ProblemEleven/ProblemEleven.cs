using System;

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

class NumberAndWords
{
    static void Main(string[] args)
    {
        
	    Console.WriteLine("Enter number:");
        try
        {
            int a = int.Parse(Console.ReadLine());
        
       
        
		    switch(a/100)
            {
		        case 0:
			        if(a==0){Console.WriteLine("zero");}break;
		
		        case 1:Console.Write("one hundred ");break;
		        case 2:Console.Write("two hundred ");break;
		        case 3:Console.Write("three hundred ");break;
		        case 4:Console.Write("four hundred ");break;
		        case 5:Console.Write("five hundred ");break;
		        case 6:Console.Write("six hundred ");break;
		        case 7:Console.Write("seven hundred ");break;
		        case 8:Console.Write("eight hundred ");break;
		        case 9:Console.Write("nine hundred ");break;
                default: break;
		
		    }
		    switch(a%100/10)
            {
		        case 1:
			        if(a%10==0){Console.Write("ten");break;
			        }
			        if(a%10==1){Console.Write("eleven");break;
			        }
			        if(a%10==2){Console.Write("twelve");break;
			        }
			
			        if(a%10==3){Console.Write("and thirteen");break;
			        }	
			        if(a%10==4){Console.Write("and fourteen");break;
			        }	
			        if(a%10==5){Console.Write("and fifteen");break;
			        }	
			        if(a%10==6){Console.Write("and sixteen");break;
			        }	
			        if(a%10==7){Console.Write("and seventeen");break;
			        }	
			        if(a%10==8){Console.Write("and eighteen");break;
			        }	
			        if(a%10==9){Console.Write("and nineteen");break;
			        }				
		        break;
		        case 2:Console.Write("twenty ");break;
		        case 3:Console.Write("thirty ");break;
		        case 4:Console.Write("forty ");break;
		        case 5:Console.Write("fifty ");break;
		        case 6:Console.Write("sixty ");break;
		        case 7:Console.Write("seventy ");break;
		        case 8:Console.Write("eighty ");break;
		        case 9:Console.Write("ninty ");break;
                default: break;		
		    }
            switch (a % 10)
            {
                case 1:
                    if (a % 100 / 10 == 1)
                    {
                        Console.WriteLine(""); break;
                    }
                    else
                    {
                        Console.WriteLine("one");
                    }; break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid number entered. Please try again!");
        }
    }
}

