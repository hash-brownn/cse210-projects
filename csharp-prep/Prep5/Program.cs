using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = squareNumber(number);
        displayResult(name, square);
    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
   
    static string PromptUserName()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Type a number? ");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;

    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
     static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}