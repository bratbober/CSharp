using _011_Lambda;
// Лямбда оператор
/*MyDelegate myDelegate = (int a, int b) =>
{
    return a + b;
};
int result = myDelegate(5, 10);
Console.WriteLine(result);*/

MyDelegate myDelegate = (a, b) => a + b;
   
int result = myDelegate(5, 10);
Console.WriteLine(result);