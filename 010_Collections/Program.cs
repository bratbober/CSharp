// ArrayList

using _010_Collections;
using System.Collections;
using System.Globalization;

/*ArrayList arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add(100.22);
arrayList.Add("Hello");
arrayList.Add(true);
foreach(object i in arrayList)
{
    Console.WriteLine(i);
}*//*

Console.WriteLine(arrayList[0]);
int a = (int)arrayList[0];*/


/*ArrayList arrayList = new ArrayList() 
{ 
    10, 45, -3, 0, 100, 9, 55  
};
arrayList.Add(88);
arrayList.AddRange(new[] {1, -33, 99});
arrayList.RemoveAt(0);
arrayList.Remove(55);
arrayList.Insert(7, 1000);
arrayList.Reverse();
arrayList.Sort();
foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}*/

/*ArrayList arrayList = new ArrayList()
{
    new Person()
   {
        LastName = "Danylo",
        Age = 90
   },
    new Person()
   {
        LastName = "Max",
        Age = 24
   },

   new Person()
   {
        LastName = "John",
        Age = 40
   },
   
   new Person()
   {
        LastName = "Vill",
        Age = 50
   }
};
arrayList.Sort();
foreach(var p in arrayList)
{
    Console.WriteLine(p);
}
Console.WriteLine("-------------------------");
arrayList.Sort(new PersonAgeComparer());
foreach (var p in arrayList)
{
    Console.WriteLine(p);
}*/

/*List<int> numbers = new List<int>() 
{
    20, 10, 1000, 50, 60
};
numbers.Add(100);
numbers.AddRange(new List<int> { 1, 2, 3});
numbers.Remove(1);
numbers.Sort((a,b) => a.CompareTo(a));

foreach(int item  in numbers)
{
    Console.WriteLine(item);
}*/

/*Stack<int> stack = new Stack<int>();

stack.Push(10);
stack.Push(20);
stack.Push(30);

foreach(int item in stack)
{
    Console.WriteLine(item);
}*/

/*Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(10);
queue.Enqueue(14);
queue.Enqueue(100);
queue.Dequeue();
foreach (int item in queue)
{
    Console.WriteLine(item);
}*/

// SortedDictionary

/*SortedDictionary<int,string> d = new SortedDictionary<int,string>();
d.Add(10, "bar");
d.Add(5, "tree");
d.Add(1, "dog");

foreach(var item in d)
{
    Console.WriteLine($"{item.Key}:{item.Value}");
}*/



