namespace _011_Delegates
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
