// Делегати - це об'єкти, які посилаються на методи
// і дозволяють викликати ці методи через делегат.

// - для передачі функції методів як параметр інших методів
// - є основою для поді і зворотних викликів

using _011_Delegates;

/*MyClass myClass = new MyClass();  
MyDelegate del = myClass.Method;
del();
del = myClass.Method2;
del();*/

/*Messanger messanger = new Messanger();
MessageDelegate message = messanger.printMessage;
message("Hello Delegates!");
*/

// Example 2

/*// Створення та ініціалізація масиву (10 об'єктів)
// за допомогою синтаксису списку ініціалізації
Person[] peopleArray = new Person[]
{
            new Person("Charlie", 45),
            new Person("Diana", 19),
            new Person("Bob", 30),
            new Person("Edward", 52),
            new Person("Alice", 25),
            new Person("Jack", 33),
            new Person("Ivy", 49),
            new Person("Fiona", 38),
            new Person("George", 65),
            new Person("Hannah", 21),
};

// Виведення елементів масиву для перевірки
Console.WriteLine("Person Array initialized using collection initializer:");
foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}
void SortPeople(Person[] people, MyComparerDelegate comparer)
{
    int n = people.Length;
    bool swapped; 
    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

       
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (comparer(people[j], people[j+1]))
            {

                Person temp = people[j];
                people[j] = people[j + 1];
                people[j + 1] = temp;

                swapped = true;
            }
        }
        if (swapped == false)
        {
            break;
        }
    }
}
bool CompareByAge(Person p1, Person p2)
{
    return p1.Age > p2.Age;
}
bool CompareByName(Person p1, Person p2)
{
    return string.Compare(p1.Name, p2.Name) < 0;
}

SortPeople(peopleArray, CompareByAge);
Console.WriteLine("\nSorted by age\n");
foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}

SortPeople(peopleArray, CompareByName);
Console.WriteLine("\nSorted by name\n");
foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}*/

// Example 3

/*MyClass myClass = new MyClass();
MyDelegate del = myClass.Method;
del += myClass.Method2;
del -= myClass.Method;
del();*/

// Example 4 (generic delegates)

/*int Add(int a, int b)
{
    return a + b;
}
int Multiply(int a, int b)
{
    return a * b;
}
double MultiplyDouble(double a, double b)
{
    return a * b;
}
string AddStr(string a, string b)
{
    return a + b;
}

OperationDelegate<double> operation = MultiplyDouble;
double res = operation(4.8, 5.9);
Console.WriteLine(res);

OperationDelegate<string> operStr = AddStr;
string resStr = operStr("Hello, ", "World!");
Console.WriteLine(resStr);*/

