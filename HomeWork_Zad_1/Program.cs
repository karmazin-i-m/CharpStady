using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3, 0);
            Point B = new Point(1, 2);
            Point O = new Point(0, 0);

            Vector OA = new Vector(O, A);
            Vector OB = new Vector(O, B);

            Console.WriteLine($"Vector OA: x={OA.VectorPoint.X}, y={OA.VectorPoint.Y}");
            Console.WriteLine($"Vector AB: x={OB.VectorPoint.X}, y={OB.VectorPoint.Y}");

            Vector vector = OA + OB;
            Console.WriteLine($"Vector vector: x={vector.VectorPoint.X}, y={vector.VectorPoint.Y}");

            vector = OA - OB;
            Console.WriteLine($"Vector vector: x={vector.VectorPoint.X}, y={vector.VectorPoint.Y}");

            Console.ReadKey();
        }
    }
    struct Vector
    {
        private Point start;
        private Point finish;
        private Point vector;
        public Vector(Point start, Point finish)
        {
            this.start = start;
            this.finish = finish;
            this.vector = new Point(finish.X - start.X, finish.Y - start.Y);
        }

        private Vector(Point vector)
        {
            this.vector = vector;
            this.start = default;
            this.finish = default;
        }
        public Point VectorPoint => vector;
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(new Point(vector1.VectorPoint.X + vector2.VectorPoint.X, vector1.VectorPoint.Y + vector2.VectorPoint.Y));
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(new Point(vector1.VectorPoint.X - vector2.VectorPoint.X, vector1.VectorPoint.Y - vector2.VectorPoint.Y));
        }
    }

    struct Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X => this.x;
        public int Y => this.y;
    }
}
