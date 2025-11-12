namespace _003_Task
{
    class Circle
    {
        Point point;
        int radius;

        public Circle(Point point, int radius)
        {
            this.point = point;
            this.radius = radius;
        }
        public int Area()
        {
            return (int)Math.PI * radius * radius;
        }
        public int Lenghs()
        {
            return (int)(2*Math.PI * radius);
        }
        public bool InCircle(Point point1)
        {
            return Math.Pow(point1.GetX() - point.GetX(),2)+ Math.Pow(point1.GetY() - point.GetY(), 2) <= Math.Pow(radius,2);
        }
        
    }
}
