namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program{
    static void Main(string[] args)
    {
        // Define the variables to hold the numbers we need to add
        int number1 = 0; // Since we will be doing math it needs to be numeric
        int number2 = 0; // Since we will be doing math it needs to be numeric
        int number3 = 0; // Since we will be doing math it needs to be numeric

        // Define a variable to hold the sum of the numbers
        int[] numbers = new int[3];
        int sum = 0;
        double average = 0;

        Console.WriteLine("--- Starting program ---");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i] + " is the number you have in the " + i + " Array position" );
            sum += numbers[i];
        }
        
        average = (double)sum / numbers.Length;
        
        Console.WriteLine("Sum of the numbers is: " + sum);
        Console.WriteLine("Average of the numbers is: " + average);
        
        intArrayToMeidan(numbers);

        Console.WriteLine("--- Ending program ---");
    }

    static void intArrayToMeidan(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            int nextNumber = i + 1;
            
            if (nextNumber > array.Length - 1)
            {
                Console.WriteLine("There are no more elements");
                break;
            }
            
            if (array[nextNumber] < array[i])
            {
                Console.WriteLine("tried");
                array[nextNumber] = array[i];
                array[i] = nextNumber;
            }
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();
    }
    
}