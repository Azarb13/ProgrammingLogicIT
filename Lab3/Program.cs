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
           Console.WriteLine("\n Problem 4: Multiples of 10 from 10 to 1000");
            int multiple = 10;
            while (multiple <= 1000)
            {
                Console.WriteLine(multiple);
                multiple += 10;
            }

            Console.WriteLine("\nProblem 5: Seasons of the Year");
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            Console.WriteLine("\n Problem 6: Days of the Week (1–7)");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number from 1 to 7 to get the day of the week: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber))
            {
                if (dayNumber >= 1 & dayNumber <= 7)
                {
                    Console.WriteLine($"Day {dayNumber} is {days[dayNumber - 1]}.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }

            Console.WriteLine("\n Problem 7: Temperature Tracker");
            int[] temperatures = { 72, 65, 80, 58, 75 };
            Array.Sort(temperatures);

            Console.WriteLine("Temperatures in ascending order:");
            foreach (int temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("Highest temperature: {temperatures[temperatures.Length - 1]}");
            Console.WriteLine("Lowest temperature: {temperatures[0]}");

            Console.WriteLine("\n Problem 8: Reverse Countdown");
            int[] countdown = { 5, 4, 3, 2, 1 };
            Array.Reverse(countdown);

            Console.WriteLine("After reversing the array:");
            for (int i = 0; i < countdown.Length; i++)
            {
                Console.WriteLine(countdown[i]);
    		}
        }

