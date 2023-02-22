namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a value for N as a command-line argument.");
                return;
            }

            int n = int.Parse(args[0]);

            if (n == 0)
            {
                Console.WriteLine("N should not be 0.");
                return;
            }

            double harmonicNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                harmonicNumber += 1.0 / i;
            }

            Console.WriteLine("The " + n + "th harmonic number is: " + harmonicNumber);
        }
    }
        }
    

        
    
