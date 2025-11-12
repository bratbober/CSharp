namespace _003_Task
{
    class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void Print()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
    }
    
}
