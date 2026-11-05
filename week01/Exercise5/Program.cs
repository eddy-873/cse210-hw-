using System;

class Program
{
    static void Main(string[] args)
    {
        // calling the Welcome function //
        DisplayWelcome();

        // Getting the user's name //
        String name = PromptUserName();

        // Getting the user's favorite number //
        int number = PromptUserNumber();

        // calculate the square of the number //
        int square = SquareNumber(number);

        // Display the result //
        DisplayResult(name, square);

    }
    // Display the welcome message //
    static void DisplayWelcome()

    {
        Console.WriteLine("Welcome to the program.");
    }
    // Ask for and returns the user's name //
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        return name;
    }
    // Asking for and returns the user's favorite  number
    static int PromptUserNumber()
    {
        Console.WriteLine("Please Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }
    // Calculating and returns the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }
     // Display the user's name and the squared number
     static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}