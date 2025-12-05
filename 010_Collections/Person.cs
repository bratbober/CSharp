namespace _010_Collections
{
    class Person : IComparable
    {
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string LastName, int Age)
        {
            this.LastName = LastName;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"LastName: {LastName}, Age: {Age}";
        }

        public int CompareTo(object? obj)
        {

            if (obj is Person)
            {
                Person other = (obj as Person);

                return this.LastName.CompareTo(other.LastName);
            }

            throw new NotImplementedException();

        }
    }
}
