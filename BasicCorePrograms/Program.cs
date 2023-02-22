using System;

class QuotientAndRemainder
{
    static void Main()
    {
        int a, b, temp;

        Console.Write("Enter the first number: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }
}






