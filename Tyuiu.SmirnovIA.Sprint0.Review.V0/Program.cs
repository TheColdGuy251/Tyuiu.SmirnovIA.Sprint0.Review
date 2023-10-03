using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SmirnovIA.Sprint0.Review.V0.Lib;

namespace Tyuiu.SmirnovIA.Sprint0.Review.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Z:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ds.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}
