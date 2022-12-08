//wap to get value & size of rectangular array from user and perform Arithmetic operation...
using System;
class Array2{
    public static void main(String[] args){
        Console.Write("Enter Size of Array : ");
        int count = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[count,count];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                Console.Write("Enter Value of Array" + i + "" + j + " : ");
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Value Of Array...");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        int add = 0;
        int sub = 0;
        int mul = 0;
        int div = 0;
        int mod = 0;
        Console.WriteLine("Enter Number...\n\t 0 = Exit \n\t 1 = Addition \n\t 2 = Subtraction \n\t 3 = Multiplication \n\t 4 = Divison \n\t 5 = Modulas");
        int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            { 
                case 0:
                    Console.WriteLine("Invalid Input...");
                    Environment.Exit(0);                    
                    break;

                case 1:
                    for (int i = 0; i < count; i++)
                     {
                        for (int j = 0; j < count; j++)
                               {
                                    add += arr[i,j];
                               }
                      }
                    Console.WriteLine("Addition : " + add);
                    break;

                case 2:
                     for (int i = 0; i < count; i++)
                     {
                        for (int j = 0; j < count; j++)
                               {
                                    sub -= arr[i,j];
                               }
                      }
                     Console.WriteLine("Subtraction : " + sub);
                    break;

                case 3:
                     for (int i = 0; i < count; i++)
                     {
                        for (int j = 0; j < count; j++)
                               {
                                    mul *= arr[i,j];
                               }
                      }
                     Console.WriteLine("Multiplication : " + mul);
                    break;

                case 4:
                     for (int i = 0; i < count; i++)
                     {
                        for (int j = 0; j < count; j++)
                               {
                                    div /= arr[i,j];
                               }
                      }
                     Console.WriteLine("Divison : " + div);
                    break;

                case 5:
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            mod %= arr[i, j];
                        }
                    }
                    Console.WriteLine("Modulas : " + mod);
                    break;
                     
                default:
                    Console.Write("Invalid Entry...");
                    break;
            }
        
        Console.Read();
    }
}