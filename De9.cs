using System;
class De9{
    public static void main(String[] args){
        Console.Write("Enter Size of Array : ");
        int count = Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[count,count];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                Console.Write("Enter Value of Array" + i + "" + j +  " : ");
                a[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Value Of Array...");
        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }
}