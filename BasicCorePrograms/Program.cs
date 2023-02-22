using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a number as a command-line argument.");
            return;
        }

        int n = int.Parse(args[0]);

        Console.WriteLine("Prime factors of " + n + ":");
        for (int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                Console.WriteLine(i);
                n /= i;
            }
        }

        if (n > 1)
        {
            Console.WriteLine(n);
        }
    }
}



