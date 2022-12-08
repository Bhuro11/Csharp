
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class De7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("for loop");

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }


            //while loop
            Console.WriteLine("while loop");

            int a = 0, b = 0;
            while (a < 5)
            {

                while (b <= a)
                {
                    Console.Write("*");
                    b = b + 1;

                }
                Console.Write("\n");
                a = a + 1;

            }

            // Do while loop
            Console.WriteLine("do while loop");
            int c = 0, d = 0;

            do
            {

                do
                {

                    Console.Write("*");
                    d++;


                } while (d <= c);

                Console.Write("\n");
                c++;
            } while (c < 5);




            Console.Read();
        }
    }



