using System;
class Boxing
{
    public static void main(String[] args) 
    {
        int a;
        Console.Write("Enter Value For A : ");
        a = int.Parse(Console.ReadLine());
        object o;

        o = a;//Boxing
        Console.WriteLine(o);
        int b = (int)o;//unboxing
        Console.WriteLine(b);
        Console.ReadKey();
    }
}