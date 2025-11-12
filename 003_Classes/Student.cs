
namespace _003_Classes
{
    class Student
    {
        private string name;
        private string surname;
        private int age;

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        public string GetSurname() { return surname; }
        public void SetSurname(string surname) { this.surname = surname; }
        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
        public void Print()
        {
            Console.WriteLine($"Name: {name} | Surname: {surname} | Age: {age}");
        }
    }
}
