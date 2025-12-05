namespace _010_Collections
{
    class SolarSystem
    {
        List<NonSatellite> planets;

        public SolarSystem()
        {
            
        }
        public SolarSystem(List<NonSatellite> planets)
        {
            this.planets = planets;
        }
        public override string ToString() {
            string s = string.Empty;

            foreach (NonSatellite planet in planets) {
                Console.WriteLine(s+=planet);
            }

            return s;
        }
        public NonSatellite Search(string a)
        {
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == a)
                {
                    return planets[i];
                }
            }
            for (int i = 0; i < planets.Count; i++) {
                for (int j = 0; i < planets[i].Satellites.Count; j++) {
                    if (planets[i].Satellites[j].Name == a)
                    {
                        return (NonSatellite)planets[i].Satellites[j];
                    }
                }
            }
            return null;
        }
    }
}
