using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01G_MiniRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 Ergebnis,Zahl1,Zahl2;
            Console.Write("Addition\n\n");
            Console.WriteLine("Geben Sie die 1. Zahl ein:\n");
            Zahl1= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nGeben Sie die 2. Zahl ein:\n");
            Zahl2 = Convert.ToInt64(Console.ReadLine());
            Ergebnis = Zahl1 + Zahl2;
            Console.WriteLine("\nDas Ergebnis ist = {0} ",Ergebnis);
            Console.ReadKey();
        }
    }
}
