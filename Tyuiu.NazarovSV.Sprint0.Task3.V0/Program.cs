using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarovSV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NazarovSV.Sprint0.Task3.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Sum(8, 7));
            Console.ReadKey();
        }
    }
}