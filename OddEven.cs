using System;
public class OddEven
{
    public static void main(String[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        int a;
        Console.Write("Enter A :");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        if (a % 2 == 0)
        {
            Console.Write("Even");
        }
        else
        {
            Console.Write("odd");
        }
        Console.ReadKey();
    }
}