using System;
class De8{
    public static void main(String[] args){
        Console.Write("Enter Size of Array : ");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter Value of Array" + i + " : ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Value Of Array...");
        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}