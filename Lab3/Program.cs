namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Problem 1: Simple For Loop");
        // Print numbers from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n Problem 2: Even Numbers from 1 to 20");
        // Show even numbers from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Problem 3: While Loop Countdown");
         // Countdown from 5 to 1
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }
    }
        }

