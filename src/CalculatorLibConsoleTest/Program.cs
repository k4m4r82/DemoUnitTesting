using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CalculatorLib;

namespace CalculatorLibConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Calculator();

            Console.WriteLine("Hasil {0} + {1} = {2}", 5, 2, cal.Tambah(5, 2));
            Console.WriteLine("Hasil {0} - {1} = {2}", 5, 2, cal.Kurang(5, 2));
            Console.WriteLine("Hasil {0} * {1} = {2}", 5, 2, cal.Kali(5, 2));
            Console.WriteLine("Hasil {0} / {1} = {2}\n", 10, 2, cal.Bagi(10, 2));

            Console.ReadKey();
        }
    }
}
