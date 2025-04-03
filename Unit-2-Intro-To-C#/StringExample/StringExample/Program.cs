namespace StringExample;

class Program
{
    static void Main(string[] args)
    {
        string string1 = "a";
        string string2 = "b";
        
        if (string1.CompareTo(string2) > 0)
        {
            Console.WriteLine(" string 1 is greater than string 2");
        }
        else
        {
            Console.WriteLine(" string 1 is NOT greater than string 2");
        }
        
        if (string1.CompareTo(string2) < 0)
        {
            Console.WriteLine(" string 1 is less than string 2");
        }
        else
        {
            Console.WriteLine(" string 1 is NOT less than string 2");
        }
        
        if (string1.CompareTo(string2) == 0)
        {
            Console.WriteLine(" string 1 is equal than string 2");
        }
        else
        {
            Console.WriteLine(" string 1 is NOT equal than string 2");
        }
    }
}