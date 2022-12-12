using System;
class De5 { 
    public static void Main(String[] args){
       /* Console.WriteLine("Enter Number Of Student : ");
        int count = Convert.ToInt32(Console.ReadLine());
        String[] nm = new String[count];
        int[] rn = new int[count];
        int[] m1 = new int[count];
        int[] m2 = new int[count];
        int[] m3 = new int[count];
        int[] m4 = new int[count];*/
        
            Console.Write("Enter Student Name    : ");
            String nm = Console.ReadLine();
            Console.Write("Enter Student Roll No : ");
            int rn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Csharp Mark (out of 100)   : ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Java Mark (out of 100)     : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Adv. Net Mark (out of 100) : ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student OS Mark (out of 100)       : ");
            int m4 = Convert.ToInt32(Console.ReadLine());
            int total = m1 + m2 + m3 + m4;
            int per = (m1 + m2 + m3 + m4) / 4;
            Console.WriteLine("");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(".....Marksheet.....");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Name   Roll No   Csharp   Java   Adv.Net   OS   Total   Percentega");
        Console.WriteLine(nm + "\t " + rn + "\t " + m1 + "\t  " + m2 + "\t  " + m3 + "\t  " + m4 + "\t " + total + "\t " + per + "%");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(".....Grade.....");
        Console.WriteLine("----------------------------------------"); 
        Console.WriteLine("");
        if (m1 > 30 && m2 > 30 && m3 > 30 && m4 > 30)
        {
            if (per >= 70)
            {
                Console.WriteLine("Congratulations....... \n You Are A Distinct");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Congratulations....... \n You Are A First");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Excellent....... \n You Are A Secound");
            }
            else
            {
                Console.WriteLine("Good....... \n You Are A Pass");
            }                                                                                                                                                                                                         
        }
        else {
            Console.Write("Sorry.....\n Try To  Next Time");
        }
     
        Console.Read();
    }
}
