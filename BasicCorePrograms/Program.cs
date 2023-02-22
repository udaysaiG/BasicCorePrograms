using System;

class QuotientAndRemainder
{
    static void Main(string[] args)
    {
        int num1, num2, num3;

        Console.WriteLine("Enter three numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("{0} is the largest number", num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("{0} is the largest number", num2);
        }
        else
        {
            Console.WriteLine("{0} is the largest number", num3);
        }
    }
}





