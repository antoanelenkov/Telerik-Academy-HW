using System;
using System.IO;

/*•	Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
  •	Find in MSDN how to use System.IO.File.ReadAllText(…).
  •	Be sure to catch all possible exceptions and print user-friendly error messages.*/


class ReadFileContents
{
    static void Main()
    {
        string fileName = @"C:\Users\Antoan Elenkov\Documents\Visual Studio 2013\Projects\C#2Homework\07. Exception Handling - Homework\03. Read file contents\New Text Document (2).txt";
        TextReader reader = null;
        try
        {
            reader = new StreamReader(fileName);
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("We are sorry, you do not have permittion to use this file!");
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can not find file:\n{0}.", fileName);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can not open the file {0}", fileName);
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
        }
    }
}
