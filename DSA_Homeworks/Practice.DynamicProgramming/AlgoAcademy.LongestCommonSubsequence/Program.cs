/*Дадени са ви 2 редици от числа.Първата редица има дължина N на брой числа, а втората – M на
брой числа.Намерете дължината на най-дългата обща подредица от числа измежду двете
редици.
Не е задължително числата в намерената подредица да са задължително последователни в
редиците.
Например, ако имаме редиците
• 24, 13, 10, 25, 1, 21, 26
• 13, 26, 10, 1, 23, 24, 21
то най-дългата обща подредица измежду тях ще е 13, 10, 1, 21 и нейната дължина е 4.
Входни данни
Входните данни ще бъдат дадени на конзолата.
На първият ред ще бъде дадено числото N.
На вторият ред ще бъде дадено числото M.
На третия ред ще са дадени N-те числа от първата редица разделени с по 1 интервал.
На четвъртия ред ще са дадени M-те числа от втората редица разделени с по 1 интервал.
Изходни данни
Изходните данни ще се извеждат на конзолата.
На единствения ред на стандартния изход изкарайте дължината на най-дългата обща подредица.
Ограничения
• N и M ще бъдат цели числа между 1 и 100, включително.
• Числата в двете подредици ще имат дължина межди 1 и 100 цифри.
• Позволено време за работа на програмата: 0.1 секунда.Позволена памет: 16 MB.*/

namespace AlgoAcademy.BigIntegerestCommonSubsequence
{
    using System;
    using System.Numerics;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            var firstSequenceLength = int.Parse(Console.ReadLine());
            var secondSequenceLength = int.Parse(Console.ReadLine());

            var firstSequence = Console.ReadLine().Split(' ');
            var secondSequence = Console.ReadLine().Split(' ');

            var buffer = new int[secondSequenceLength+1, firstSequenceLength+1];

            for (int i = 1; i < buffer.GetLength(0); i++)
            {
                for (int j = 1; j < buffer.GetLength(1); j++)
                {
                    if (secondSequence[i-1] == firstSequence[j-1])
                    {
                        buffer[i, j] = buffer[i - 1, j - 1]+1;
                    }
                    else
                    {
                        buffer[i, j] = buffer[i, j] + (new int[] { buffer[i - 1, j], buffer[i, j - 1] }).Max();
                    }
                }
            }

            Console.WriteLine(buffer[secondSequenceLength,firstSequenceLength]);
        }
    }
}
