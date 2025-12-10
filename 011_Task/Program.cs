using _011_Task;

void MyForeach(Student[] students,MyAction<Student> action)
{
    foreach (var student in students)
    {
        action(student);
    }
}
void FullNameUpper(Student student)
{
    Console.WriteLine($"FirstName: {student.FirstName.ToUpper()}\t LastName: {student.LastName.ToUpper()}");
}




Student[] students = 
{
    new Student{FirstName="John",LastName="Doe"},
    new Student{FirstName="Jane",LastName="Smith"},
    new Student{FirstName="Yana",LastName="Johnson"},
    new Student{FirstName="Bob",LastName="Brown"},
};

MyAction<Student> action = FullNameUpper;
MyForeach(students ,action);



// Готові делегати в .NET

// Action<T>
// public delegate void Action<in T>(T obj);

// Func<T, TResult>
// public delegate TResult Func<in T, out TResult>(T arg);

// Predicate<T>
// public delegate bool Predicate<in T>(T obj);

// Comparison<T>
//public delegate int Comparison<in T>(T x, T y);