﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ConsoleColor color = ConsoleColor.Black;

            for (ConsoleColor color = ConsoleColor.Black; color < ConsoleColor.White; color++)
            {
                if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
                else Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = color;
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
