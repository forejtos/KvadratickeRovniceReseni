using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickeRovniceReseni
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zadej c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine($"\nKořen:\nx1 = {onlyA(b, c)}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\nKořeny:\nx1 = {x1(a, b, c)} \nx2 = {x2(a, b, c)}");
                Console.ReadLine();
            }
        }
        public static double x1(double a, double b, double c)
        {
            double diskriminant = Math.Pow(b,2) - 4 * a * c;
            double koren1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
            return koren1;
        }
        public static double x2(double a, double b, double c)
        {
            double diskriminant = Math.Pow(b, 2) - 4 * a * c;
            double koren2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
            return koren2;
        }
        public static double onlyA(double b, double c)
        {
            double korenX = -c / b;
            return korenX;
        }
    }
}
