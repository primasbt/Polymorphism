using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Select Printer: ");
            Console.WriteLine("1. Epson ");
            Console.WriteLine("2. Canon ");
            Console.WriteLine("3. LaserJet\n ");

            Console.Write("Printer numbers [1...3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new Laser();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}