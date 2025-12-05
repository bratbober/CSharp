namespace _010_Collections
{
    class Planet
    {
        public string Name { get; set; }
        public int Radius { get; set; }
        public int Mass { get; set; }
        public int Volume { get; set; }
        public int Area { get; set; }
        public int Period_Obert {  get; set; }

        public Planet()
        {
            
        }
        public Planet(string Name, int Radius, int Mass, int Volume, int Area, int Period_Obert)
        {
            this.Name = Name;
            this.Radius = Radius;
            this.Mass = Mass;
            this.Volume = Volume;
            this.Area = Area;
            this.Period_Obert = Period_Obert;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Radius: {Radius}, Mass: {Mass}, Volume: {Volume}, Area: {Area}, Period_Obert: {Period_Obert}";
        }
    }
}
