namespace Class_Zad_3
{
    struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get => x;
        }
        public int Y
        {
            get => y;
        }
    }
}
