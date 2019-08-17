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
            Vector vector1 = new Vector(new Point(1,2),new Point(4,8));
            Vector vector2 = new Vector(new Point(), new Point());

            Vector vector3 = vector1 + vector2;

            Console.WriteLine($"Vector 3: start x={vector3.StartPoint.X}, start y={vector3.StartPoint.Y}");
            Console.WriteLine($"Vector 3: start x={vector3.FinishPoint.X}, start y={vector3.FinishPoint.Y}");

            Console.ReadKey();
        }
    }
    struct Vector
    {
        Point start;
        Point finish;
        public Vector(Point start, Point finish)
        {
            this.start = start;
            this.finish = finish;
        }
        public Point StartPoint => start;
        public Point FinishPoint => finish;
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Point start = new Point(vector1.start.X + vector2.start.X, vector1.start.Y + vector2.start.Y);
            Point finish = new Point(vector1.finish.X + vector2.finish.X, vector1.finish.Y + vector2.finish.Y);
            return new Vector(start,finish);
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
