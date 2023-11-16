//First
using System;

namespace HOMEWORK_BT
{
    class Program
    {
        static void Main()
        {
            Console.Write("x=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("str=");
            string str = Console.ReadLine()?? "";

            if(a > str.Length)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.ToLower());

            //Second

            int x=15;
            int y=10;

            if(x > y)
                Console.WriteLine("x is greater than y");
            else if(x < y)
                    Console.WriteLine("x is less than y");
                else if(x == y)
                        Console.WriteLine();
                    else  
                        Console.WriteLine("x and y are not comparable!!!");

            //Third

            string hafta = Console.ReadLine()??"";

            string week = hafta switch{
                "Dushanba" => "Monday",
                "Seshanba" => "Tuesday",
                "Chorshanba" => "Wednesday",
                "Payshanba" => "Thursday",
                "Juma" => "Friday",
                "Shanba" => "Saturday",
                "Yakshanba" => "Sunday",
                _ => "No Day as this!!!"
            };
            Console.WriteLine(week);
        }
    }
}
