﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01G_MiniRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            String RechenOperation;
            Console.Write("Was möchten Sie machen?\n\n");
            Console.Write("Addieren(a)  Subtrahieren(s)\n\n");
            RechenOperation = Console.ReadLine();
            Console.Clear();
            switch (RechenOperation)
                {
                    case "a":
                        Addieren();
                        break;
                    case "s":
                        Subtrahieren();
                        break;
                }
            Console.ReadKey();
        }
        static void Addieren()
        {
            Console.Write("Addieren\n\n");
            Console.WriteLine("Geben Sie die 1. Zahl ein:\n");
            Int64 Zahl1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nGeben Sie die 2. Zahl ein:\n");
            Int64 Zahl2 = Convert.ToInt64(Console.ReadLine());
            Int64 Ergebnis = Zahl1 + Zahl2;
            Console.WriteLine("\nDas Ergebnis ist = {0} ", Ergebnis);

        }
        static void Subtrahieren() 
        {
            Console.Write("Subtrahieren (1.Z-2.Z)\n\n");
            Console.WriteLine("Geben Sie die 1. Zahl ein:\n");
            Int64 Zahl1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nGeben Sie die 2. Zahl ein:\n");
            Int64 Zahl2 = Convert.ToInt64(Console.ReadLine());
            Int64 Ergebnis = Zahl1 - Zahl2;
            Console.WriteLine("\nDas Ergebnis ist = {0} ", Ergebnis);
        
        }
    }
}
