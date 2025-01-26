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
        static void Main(string[] args)
        {
        }
    }
}
