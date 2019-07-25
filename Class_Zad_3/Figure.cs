using System;

namespace Class_Zad_3
{
    class Figure
    {
        private Point[] points = new Point[6];
        private string FigureName;

        private int count = 0;

        public Point? this[int index]
        {
            get
            {
                if (index > count || index < 0)
                {
                    return points[index];
                }
                return default;
            }
        }

        public string GetFigureName
        {
            get
            {
                SetFigureName(count);
                return FigureName;
            }
        }
        public void AddPoint(Point point)
        {
            if (count < points.Length)
            {
                points[count] = point;
                SetFigureName(count);
                count++;
            }
            else throw new IndexOutOfRangeException("Вы превысили длинну внутреннего масива");
        }

        private void SetFigureName(int count)
        {
            switch (count)
            {
                case 0:
                    Console.WriteLine("Такой фигуры не существует!");
                    FigureName = default;
                    break;
                case 1:
                    FigureName = "Dot";
                    break;
                case 2:
                    FigureName = "Line";
                    break;
                case 3:
                    FigureName = "Triangle";
                    break;
                case 4:
                    FigureName = "Quadrangle";
                    break;
                case 5:
                    FigureName = "Pentagon";
                    break;
                case 6:
                    FigureName = "Hexagon";
                    break;
            }
        } 
    }
}
