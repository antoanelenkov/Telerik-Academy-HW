using System;
using System.Linq;
using System.Collections.Generic;

/*
 * You are given an array of strings. Write a method that sorts the array 
 * by the length of its elements (the number of characters composing them).
*/

class SortStringLength
{
    static void Main(string[] args)
    {
        string[] array = { "programist", "Az", "busesht", "sam","edin" };
        int[] intArray = new int[array.Length];
        //SelectionSort
        for (int i = 0; i < array.Length; i++)
        {
            for (int j= i+1; j < array.Length; j++)
			{
                if (array[i].Length>array[j].Length)
                {
                    string temp = array[j];                    
                    array[j] = array[i];
                    array[i] = temp;
                } 

			}
        }
        Console.Write(String.Join(" ", array));
        Console.WriteLine(".");
    }
}

