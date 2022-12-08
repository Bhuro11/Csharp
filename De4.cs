using System;
class De4 {
    public static void main(String[] args){
        int a, b;
        Console.Write("Enter a :");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b :");
        b = Convert.ToInt32(Console.ReadLine());
        if (a == b)
        {
            Console.WriteLine("A is Equal to B");
        }
        else 
        {
            Console.WriteLine("A is not equal to B");
        }
        if (a < b)
        {
            Console.WriteLine("A less than B");
        }
        else
        {
            Console.WriteLine("A not less than  B");
        }
        if (a > b)
        {
            Console.WriteLine("A greater than B");
        }
        else
        {
            Console.WriteLine("A not greater than B");
        }
        if (a <= b)
        {
            Console.WriteLine("A less than or equal to B");
        }
        else
        {
            Console.WriteLine("A not less than or equal to B");
        }
        if (b >= a)
        {
            Console.WriteLine("B greater than or Eqaul to A");
        }
        else
        {
            Console.WriteLine("B not greater than or equal to A");
        }
        Console.ReadKey();
    }
}