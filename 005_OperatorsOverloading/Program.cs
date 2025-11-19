using _005_OperatorsOverloading;

/*MyClass obj1  = new MyClass{X = 4};
MyClass obj2  = new MyClass{X = 3};

MyClass obj3 = obj1 + obj2;
obj3.Print();
obj3 = obj1 - obj2;
obj3.Print();

obj1 += obj2;
obj1.Print();
*/

/*
MyArray myArray = new()
{
    Arr =[ 1, 2, 3, 4, 5 ]
};
myArray.Print();
Console.WriteLine(myArray.Length);
myArray[2] = 100;
myArray.Print();

*/

/*
Student student = new Student() { Name = "John", Age = 30};
Console.WriteLine(student.ToString());
Console.WriteLine(student);
*/

/*Group group = new Group(new Student[]
{
    new Student { Name = "John", Age = 20},
    new Student { Name = "Den", Age = 25},
    new Student { Name = "Jack", Age = 21},
});

Console.WriteLine(group);
*/



/*Student[] students = new Student[]
{
    new Student { Name = "John", Age = 20},
    new Student { Name = "Den", Age = 25},
    new Student { Name = "Jack", Age = 21},
};*/
/*string[] studentsStr = students.Select(s => s.ToString() + "\n").ToArray();
Console.WriteLine(string.Join(",", studentsStr));*/




/*Group group = new Group(new Student[]
{
    new Student { Name = "John", Age = 20},
    new Student { Name = "Den", Age = 25},
    new Student { Name = "Jack", Age = 21},
});
Console.WriteLine(group);

Console.WriteLine(group[0]);
Console.WriteLine(group["Den"]);
*/

Shop shop = new Shop(new Laptop[] {
    new Laptop {Vendor = "Lenovo", Price = 10000.00},
    new Laptop {Vendor = "MSI", Price = 20000.00},
    new Laptop {Vendor = "Asus", Price = 15000.00}

});
Console.WriteLine(shop);
Console.WriteLine();
Console.WriteLine(shop[0]);
Console.WriteLine(shop["Lenovo"]);
Console.WriteLine(shop[20000.0]);



