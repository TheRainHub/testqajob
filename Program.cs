using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Init
            int xA, xB, xC, yA, yB, yC;
            double AB, BC, AC, perimeter, delta = 0.0001;
            //Input
            Console.WriteLine("Enter coordinate x of dot A:");
            xA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot A:");
            yA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot B:");
            xB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot B:");
            yB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C:");
            xC = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate y of dot C:");
            yC = int.Parse(Console.ReadLine());

            //Lengths
            Console.WriteLine();

            AB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            BC = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
            AC = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));

            Console.WriteLine("Length of AB:");
            Console.WriteLine(AB);

            Console.WriteLine("Length of BC:");
            Console.WriteLine(BC);

            Console.WriteLine("Length of AC:");
            Console.WriteLine(AC);

            //Triangle type
            Console.WriteLine();

            //without delta(may be mistakes cuz of how double works)
            //string equilateral = (Math.Abs(AB - BC) == 0 && Math.Abs(AB - AC) == 0 /*&& Math.Abs(BC - AC) == 0*/) ? "Triangle IS Equilateral" : "Triangle IS NOT Equilateral";
            //string isosceles = (Math.Abs(AB - BC) == 0 || Math.Abs(AB - AC) == 0 || Math.Abs(BC - AC) == 0) ? "Triangle IS Isosceles" : "Triangle IS NOT Isosceles";

            //version with delta
            string equilateral = (Math.Abs(AB - BC) <= delta && Math.Abs(AB - AC) <= delta /*&& Math.Abs(BC - AC) == 0*/) ? "Triangle IS Equilateral" : "Triangle IS NOT Equilateral";
            string isosceles = (Math.Abs(AB - BC) <= delta || Math.Abs(AB - AC) <= delta || Math.Abs(BC - AC) <= delta) ? "Triangle IS Isosceles" : "Triangle IS NOT Isosceles";
            string right = (((Math.Pow(AB, 2) - Math.Pow(BC, 2) - Math.Pow(AC, 2)) <= delta) || ((Math.Pow(BC, 2) - Math.Pow(AC, 2) - Math.Pow(AB, 2)) <= delta) || ((Math.Pow(AC, 2) - Math.Pow(AB, 2) - Math.Pow(BC, 2)) <= delta)) ? "Triangle IS Right" : "Triangle IS NOT Right";

            Console.WriteLine(equilateral);
            Console.WriteLine(isosceles);
            Console.WriteLine(right);

            //Perimeter
            Console.WriteLine();

            perimeter = AB + BC + AC;
            Console.WriteLine("Perimeter: " + perimeter);

            //Cycle
            Console.WriteLine();

            Console.WriteLine("Parity numbers in range from 0 to perimeter:");
            for (int i = 0; i < perimeter; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
