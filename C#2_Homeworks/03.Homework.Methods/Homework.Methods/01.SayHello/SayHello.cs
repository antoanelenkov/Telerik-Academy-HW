using System;
using System.Collections.Generic;

/*
  Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
  */

class SayHello
{
    static void PrintGreeting(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name and press \"enter\".");
        PrintGreeting(Console.ReadLine());
    }
}

