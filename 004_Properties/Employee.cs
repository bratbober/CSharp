namespace _004_Properties
{
    class Employee
    {
        string name;
        string surname;
        int age;
        uint salary;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 3)
                    name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length > 2)
                    surname = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if ((value > 0) && (value < 120))
                    age = value;
            }
        }

        public uint Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, Salary: {salary}");
        }
    }
}
