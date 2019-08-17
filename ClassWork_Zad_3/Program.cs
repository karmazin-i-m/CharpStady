using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PointInVolume pointInVolume = new PointOnThePlane(2,3);
            PointOnThePlane pointOnThePlane = (PointOnThePlane)pointInVolume;

            Console.WriteLine(pointInVolume);
            Console.ReadKey();
        }
    }

    struct PointOnThePlane
    {
        int x, y;

        public PointOnThePlane(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X => x;
        public int Y => y;
    }
    struct PointInVolume
    {
        int x, y, z;

        public PointInVolume(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X => x;
        public int Y => y;
        public int Z => z;

        public static implicit operator PointInVolume(PointOnThePlane point)
        {
            return new PointInVolume(point.X, point.Y, 0);
        }

        public static explicit operator PointOnThePlane(PointInVolume point)
        {
            return new PointOnThePlane(point.X, point.Y);
        }
    }

}
