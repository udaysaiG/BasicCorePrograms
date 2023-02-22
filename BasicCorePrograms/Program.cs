namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year (4 digits):");
            string input = Console.ReadLine();
            int year;

            while (!int.TryParse(input, out year) || input.Length != 4)
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year:");
                input = Console.ReadLine();
            }

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
        }
    }
}