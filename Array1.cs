//wap to get value & size of array from user and sum of array... (multi dimension array)
using System;
class Array1 {
    public static void main(String[] args) {
        Console.Write("Enter Size of Array : ");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[count];
        int total = 0;
        for (int i = 0; i < count; i++)
        {
                    Console.Write("Enter Value of Array" + i + " : ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    total += a[i];
        }
        Console.WriteLine("Value Of Array...");
        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
        Console.Write("Sum of Array : " + total);
        Console.Read();
    }
}