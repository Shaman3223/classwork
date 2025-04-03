namespace AddSomeNombres;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Start Program ---");
        
        int loopAmount = 3;
        int sum = 0;

        for (int i = 0; i < loopAmount; i++)
        {
           int entry = 0;
           Console.WriteLine("Please enter a number");
                   
           string input = Console.ReadLine();
           entry = int.Parse(input);

           sum += entry;
        }
        
        Console.WriteLine("Your sum is...");
        Console.WriteLine(sum);
        
        Console.WriteLine("--- End Program ---");
    }
}