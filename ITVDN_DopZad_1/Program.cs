using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_DopZad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 2, 3);
            Point b = new Point(1, 2, 3);

            Point res = a + b;
            Console.WriteLine($"Point res: x={res.X}, y={res.Y}, z={res.Z}");

            Console.ReadLine();
        }
    }

    struct Point
    {
        int x, y, z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X => this.x;
        public int Y => this.y;
        public int Z => this.z;

        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.x + point2.x, point1.y + point2.y, point1.z + point2.z);
        }
    }
}
