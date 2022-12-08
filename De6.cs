using System;
class De6 {
    public static void main(String[] args) { 
        Console.Write("Enter Week Number(1 - 7) : ");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        { 
            case 1:
                Console.Write("Monday");
                break;

            case 2:
                Console.Write("Tuesday");
                break;

            case 3:
                Console.Write("Wednesday");
                break;

            case 4:
                Console.Write("Thursday");
                break;

            case 5:
                Console.Write("Friday");
                break;

            case 6:
                Console.Write("Saturday");
                break;

            case 7:
                Console.Write("Sunday");
                break;

            default:
                Console.Write("Invalid Number");
                break;
        }
        Console.Read();
    }
}