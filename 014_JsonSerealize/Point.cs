
namespace _014_JsonSerealize
{
    
    public class Point
    {

        public int X { get; set; }

        public int Y { get; set; }

        public Point()
        {
            X = 0; 
            Y = 0;
        }
        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
