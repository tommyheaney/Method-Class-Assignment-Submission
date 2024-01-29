using System;

// Define a new class named 'Operations'
public class Operations
{
    // Define a void method named 'PerformOperation' that takes two integers as parameters
    public void PerformOperation(int number1, int number2)
    {
        // Perform a simple math operation on the first integer (e.g., add 10 to it)
        int result = number1 + 10;

        // Display the result of the operation on the first integer
        Console.WriteLine("Result of the operation on the first integer: " + result);

        // Display the second integer to the screen
        Console.WriteLine("Second integer: " + number2);
    }
}

// Define the entry point of the console application
class Program
{
    // Define the Main method which is the entry point of the application
    static void Main(string[] args)
    {
        // Instantiate the 'Operations' class
        Operations operations = new Operations();

        // Call the 'PerformOperation' method, passing in two integers
        operations.PerformOperation(5, 3);

        // Call the 'PerformOperation' method again, specifying the parameters by name
        operations.PerformOperation(number1: 15, number2: 10);

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
