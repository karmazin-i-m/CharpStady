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

            human.Move();
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
        public event EventJump JumpE = null;
        Random random = new Random(DateTime.Now.Millisecond);

        public void Move()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == random.Next(10))
                {
                    JumpE.Invoke();
                }
                Console.Write("Move ");
            }
        }

        
    }
}
