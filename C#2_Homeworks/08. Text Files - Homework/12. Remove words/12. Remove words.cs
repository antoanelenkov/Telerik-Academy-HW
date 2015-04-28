using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

//•	Write a program that removes from a text file all words listed in given another text file.
//•	Handle all possible exceptions in your methods.

//Решил съм задачата по по-труден начин, тъй като не бях сигурен какво точно се иска в условието.
//Думите за триене не са по 1 на всеки ред, а безразборно на различни редове.
//След това не съм принтирал на конзолата резултата, а съм го записал обратно в същия файл, така че преди да пуснеш задачата, погледни файла "text.txt", 
//защото след като я пуснеш, файлът ще се промени и няма да видиш, че въпросните думи са изчезнали.
class RemoveWords
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("text.txt", Encoding.GetEncoding("Windows-1251")))
            {
                var listWithWords = new List<string>();
                using (StreamReader listReader = new StreamReader("list_of_words.txt", Encoding.GetEncoding("Windows-1251")))
                {
                    string listLine = listReader.ReadLine();
                    while (listLine != null)
                    {
                        string[] forbiddenWords = listLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < forbiddenWords.Length; i++)
                        {
                            listWithWords.Add(forbiddenWords[i]);
                        }
                        listLine = listReader.ReadLine();
                    }
                }

                using (var writer = new StreamWriter("text2.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < listWithWords.Count; i++)
                        {
                            if (line.Contains(listWithWords[i]))
                            {
                                line = line.Replace(listWithWords[i], String.Empty);
                            }
                        }
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }

            //Moves the text from the second file in the first file back.
            using (StreamReader reader = new StreamReader("text2.txt", Encoding.GetEncoding("UTF-8")))
            {
                using (var writer = new StreamWriter("text.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            //Deletes the buffer file
            File.Delete("text2.txt");
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //in this case I don't need that one.
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
       
    }
}

