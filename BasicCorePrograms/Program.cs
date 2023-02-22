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

            if (n < 0 || n >= 31)
            {
                Console.WriteLine("N should be between 0 and 30 inclusive, since 2^31 overflows an int.");
                return;
            }

            int powerOfTwo = 1;

            Console.WriteLine("Powers of 2 less than or equal to 2^" + n + ":");
            Console.WriteLine(powerOfTwo);

            for (int i = 1; i <= 30; i++)
            {
                powerOfTwo *= 2;
                Console.WriteLine(powerOfTwo);
            }
        }
    }
}
        
    
