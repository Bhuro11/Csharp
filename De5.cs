using System;
class De5 { 
    public static void main(String[] args){
       /* Console.WriteLine("Enter Number Of Student : ");
        int count = Convert.ToInt32(Console.ReadLine());
        String[] nm = new String[count];
        int[] rn = new int[count];
        int[] m1 = new int[count];
        int[] m2 = new int[count];
        int[] m3 = new int[count];
        int[] m4 = new int[count];*/
        
            Console.Write("Enter Student Name : ");
            String nm = Console.ReadLine();
            Console.Write("Enter Student Roll No : ");
            int rn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Csharp Mark : ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Java Mark : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Adv. Net Mark : ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student OS Mark : ");
            int m4 = Convert.ToInt32(Console.ReadLine());
            int total = m1 + m2 + m3 + m4;
        int avg = (m1 + m2 + m3 + m4) / 4;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("....Marksheet....");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Name   Roll No   Csharp   Java   Adv.Net   OS   Total   Avg");
        Console.WriteLine(nm + "\t " + rn + "\t " + m1 + "\t  " + m2 + "\t  " + m3 + "\t  " + m4 + "\t " + total + "\t " + avg);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("....Grade....");
        Console.WriteLine("----------------------------------------");
        if (m1 > 30 && m2 > 30 && m3 > 30 && m4 > 30)
        {
            if (avg >= 70)
            {
                Console.WriteLine("Distinct");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("First");
            }
            else if (avg >= 50)
            {
                Console.WriteLine("Secound");
            }
            else
            {
                Console.WriteLine("Pass");
            }
        }
        else {
            Console.Write("You are fail");
        }
     
        Console.Read();
    }
}