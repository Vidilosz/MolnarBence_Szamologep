using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    internal class Program
    {
        static double Osszeadas(double a, double b)
        { 
            return a + b; 
        }
        static double Kivonas(double a, double b)
        {
            return a - b; 
        }
        static double Szorzas(double a, double b)
        {
            return a * b;
        }
        static string Osztas(double a, double b)
        {
            if (b != 0)
            {
                return Convert.ToString(a / b);
            }
            else
            {
                return "Matematikai hiba";
            }
        }
        static string Szazalek(double a, double b)
        {
            if (b != 0)
            {
                return Convert.ToString(a / b * 100) + "%";
            }
            else
            {
                return "Matematikai hiba";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg az első számot: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Az elvégezendő művelet jele: ");
            char jel = Convert.ToChar(Console.ReadLine());
            indit(a, b, jel);
        }
    }
}
