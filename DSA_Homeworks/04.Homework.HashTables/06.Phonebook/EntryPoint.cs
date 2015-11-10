﻿namespace _06.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EntryPoint
    {
        /*(*) A text file phones.txt holds information about people, their town and phone number:

        Mimi Shmatkata          | Plovdiv  | 0888 12 34 56
        Kireto                  | Varna    | 052 23 45 67
        Daniela Ivanova Petrova | Karnobat | 0899 999 888
        Bat Gancho              | Sofia    | 02 946 946 946
        Duplicates can occur in people names, towns and phone numbers. Write a program to read the phones file and execute a sequence of commands given in the file commands.txt:

        find(name) – display all matching records by given name(first, middle, last or nickname)
        find(name, town) – display all matching records by given name and town*/
        private static Dictionary<Tuple<List<string>, string, string>> phonebook = new HashSet<Tuple<List<string>, string, string>>();

        static void Main(string[] args)
        {
            var dict=new Dictionary<>

            phonebook.Add(new Tuple<List<string>, string, string>(new List<string>() { "Georgi", "Petrov", "igracha" }, "Varna", "088332432"));
            phonebook.Add(new Tuple<List<string>, string, string>(new List<string>() { "Joro", "Petrov", "playara" }, "Sofia", "088332432"));
            phonebook.Add(new Tuple<List<string>, string, string>(new List<string>() { "Georgi", "Iordanov", "mainata" }, "Plovdiv", "088332432"));
        }

        private static Tuple<List<string>, string, string> Find(string name)
        {
            var records=phonebook.Con
        }
    }
}
