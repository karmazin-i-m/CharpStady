using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITVDN_Zad_1
{
    public class Matrix
    {
        Random random = new Random((int)DateTime.Now.Ticks);
        static readonly object consoleKey = new object();
        char[] array = new char[26];

        private int width;
        private int heihgt;

        public Matrix()
        {
            Initialization();
        }

        public void Print(int ColumNumber)
        {
            array.Mix();
            
            int arrayLength = random.Next(3, 5);
            int topPosition = 0;
            while(true)
            {
                topPosition++;
                lock (consoleKey)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.CursorLeft = ColumNumber;
                    Console.CursorTop = topPosition;
                    if (topPosition != 0)
                    {
                        Console.CursorTop = topPosition - 1;
                        Console.WriteLine(" ");
                        Console.CursorLeft = ColumNumber;
                    }


                    char[] chainChar = new char[arrayLength];

                    array.Mix();
                    for (int i = 0; i < chainChar.Length; i++)
                    {
                        chainChar[i] = array[i];
                    }

                    for (int i = 0; i < chainChar.Length; i++)
                    {
                        if (i == chainChar.Length - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(chainChar[i]);
                            Console.CursorLeft = ColumNumber;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else if (i == chainChar.Length - 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(chainChar[i]);
                            Console.CursorLeft = ColumNumber;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.WriteLine(chainChar[i]);
                            Console.CursorLeft = ColumNumber;
                        }

                    }
                    if (topPosition == heihgt - arrayLength - 1)
                    {
                        topPosition = 0;
                        Console.CursorLeft = ColumNumber;
                        Console.CursorTop = 0;
                        for (int i = 0; i < heihgt; i++)
                        {
                            Console.CursorTop = i;
                            Console.WriteLine(" ");
                            Console.CursorLeft = ColumNumber;
                        }
                        Console.CursorTop = 0;
                    }
                }
                Thread.Sleep(random.Next(20,200));
            }
        }

        private void Initialization()
        {
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = (char)(j + 65);
            }

            Console.BufferHeight = 30;

            heihgt = Console.BufferHeight;
            width = Console.BufferWidth;
        }

        private void ClearColum(int colum)
        {
            

        }
    }
}
