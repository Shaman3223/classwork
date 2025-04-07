namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define the variables to hold the numbers we need to add
        int number1 = 0; // Since we will be doing math it needs to be numeric
        int number2 = 0; // Since we will be doing math it needs to be numeric
        int number3 = 0; // Since we will be doing math it needs to be numeric

        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");

        // Ask for the numbers one at time using the C# Console object
        //     which represents the keyboard and screen
        // Console.ReadLine() returns a string from keyboard - cannot store in an int
        Console.WriteLine("Please enter a number:  "); // Asking for the number
        string theResponse; // Define a string to hold the line of input from the keyboard
        theResponse = Console.ReadLine(); // Get a line from the keyboard
      
        // int.Parse(string) will convert a string to an int
        number1 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number2 = int.Parse(theResponse);

        Console.WriteLine("Please enter a number:  ");
        theResponse = Console.ReadLine(); // Reuse theResponse define above
        number3 = int.Parse(theResponse);

        // Add the numbers together create a sum/total
        sum = number1 + number2 + number3;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);

        Console.WriteLine("--- Ending program ---");
    }
}