using System;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("Enter the A Number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the B Number ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the C Number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b + c == 180)
            {
                Console.WriteLine("Tha Triangle is Equilateral ");
            }
            else
            {
                Console.WriteLine("The Triangle is NOT Equilateral ");
            }
        }
    }
}
