using System;
using System.IO;
using System.Net;

/*•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the 
 * current directory.
  •	Find in Google how to download files in C#.
  •	Be sure to catch all exceptions and to free any used resources in the finally block.*/

class DownloadFile
{
    static void Main()
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Console.WriteLine("The file is downloading in the moment...");
                string file = "Mercedes.jpg";
                Client.DownloadFile("http://www.mbusa.com/vcm/MB/DigitalAssets/FutureModels/2015_S-Class_Coupe/2015-S-CLASS-COUPE-FUTURE-GALLERY-001-GOE-D.jpg", file);
                Console.WriteLine("The file is succesfully downloaded!");
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message);
        }
    }
}

