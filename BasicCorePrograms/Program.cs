namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number of times to flip the coin:");
            string input = Console.ReadLine();
            int numberOfFlips;

            while (!int.TryParse(input, out numberOfFlips) || numberOfFlips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
                input = Console.ReadLine();
            }

            int numberOfHeads = 0;
            int numberOfTails = 0;
            Random random = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }

            double percentageOfHeads = ((double)numberOfHeads / numberOfFlips) * 100;
            double percentageOfTails = ((double)numberOfTails / numberOfFlips) * 100;

            Console.WriteLine("Percentage of Heads: {0}%", percentageOfHeads);
            Console.WriteLine("Percentage of Tails: {0}%", percentageOfTails);
        }
    }
}