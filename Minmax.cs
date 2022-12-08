using System;

public class Minmax
{
    public static void main(String[] args)
    {
        int a, b;
        Console.Write("Enter A :");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter B : ");
        b = int.Parse(Console.ReadLine());
        if (a == b)
        {
            Console.Write("Both Are Eqal..");
        }
        else if (a < b)
        {
            Console.WriteLine("A i Min..");
        }
        else
        {
            Console.WriteLine("B is Max..");
        }
        Console.ReadKey();
    }
}