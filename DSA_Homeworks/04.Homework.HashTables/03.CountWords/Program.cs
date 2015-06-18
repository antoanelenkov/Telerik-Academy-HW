using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/*3.  Напишете програма, която по даден текст във текстов файл, преброява колко пъти се среща всяка дума. 
 * Отпечатайте на конзолата всички думи и по колко пъти се срещат, подредени по брой срещания.
Пример: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
Резултат:
is - 2, the - 2, this - 3, text - 6*/

namespace _03.CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is the TEXT. Text, text, text - THIS TEXT! Is this the text?";
            var dictionary = new Dictionary<string, int>();
            var words = text.Split(new char[] { '.', ',', '?', '!', '-', '\'',' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }
                dictionary[word]++;
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine(word.Key + " -> " + word.Value + (word.Value==1?" time":" times"));
            }
        }
    }
}
