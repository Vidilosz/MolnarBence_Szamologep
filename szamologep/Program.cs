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
        static void Indit(double a, double b, char jel)
        {
            switch (jel)
            {
                case '+': Console.WriteLine(Osszeadas(a, b)); break;
                case '-': Console.WriteLine(Kivonas(a, b)); break;
                case '*': Console.WriteLine(Szorzas(a, b)); break;
                case '/': Console.WriteLine(Osztas(a, b)); break;
                case '%': Console.WriteLine(Szazalek(a, b)); break;
                default: Console.WriteLine("Hiba"); break;
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
            Indit(a, b, jel);
        }
    }
}
