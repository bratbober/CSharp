namespace _010_Collections
{
    class NonSatellite : Planet
    {
        public int Distance {  get; set; }
        public List<Planet> Satellites {  get; set; }

        public NonSatellite()
        {
            
        }
        public NonSatellite(string Name, int Radius, int Mass, int Volume, int Area, int Period_Obert,int Distance, List<NotSattelite> Satellites)
            : base(Name,Radius,Mass,Volume,Area,Period_Obert)
        {
            this.Distance = Distance;
            this.Satellites = Satellites;
        }
        public override string ToString()
        {

            string s = string.Empty;

            foreach (Planet planet in Satellites) {
                s += planet.ToString();
            }


            return $"Name: {Name}, Radius: {Radius}, Mass: {Mass}, Volume: {Volume}, Area: {Area}, Period_Obert: {Period_Obert}, Distance: {Distance}, Satellites: {s}";
        }
    }
}
