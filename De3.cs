using System;
class De3 {
    public static void main(String[] args) {
        int a, b;
        Console.Write("Enter a :");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b :");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.ReadKey();
    }
}