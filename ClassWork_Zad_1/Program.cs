using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.JumpE += Jump;

            for (int i = 0; i < 100; i++)
            {
                human.Move();
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        public static void Jump()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Прыгаю ");
            Console.ResetColor();
        }
    }

    delegate void EventJump();

    class Human
    {
        private EventJump jumpE = null;

        public event EventJump JumpE
        {
            add
            {
                jumpE += value;
            }
            remove
            {
                jumpE -= value;
            }
        }
        Random random = new Random(DateTime.Now.Millisecond);

        public void Move()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == random.Next(10))
                {
                    jumpE.Invoke();
                }
                Console.Write("Move ");
            }
        }

        
    }
}
