namespace _004_Properties
{
    class Rectangle
    {   
        public int Width {  get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle()
        {
            
        }
        public int Area
        {
            get
            {
                return (Width * Height);
            }
        }
        public int Perimetr
        {
            get
            {
                return 2*(Width + Height);
            }
        }
    }
}
