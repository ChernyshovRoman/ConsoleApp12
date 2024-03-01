using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            y = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
            Console.WriteLine("y = " + Math.Round(y, 4));
            Console.ReadLine();
        }
    }
}
