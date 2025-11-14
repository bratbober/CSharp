// Перчислення - це  набір іменованих констант

/*Console.WriteLine("Введіть номер дня: ");
DayOfWeek day = (DayOfWeek)Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case DayOfWeek.Monday:
        Console.WriteLine("Понеділок");
        break;
    case DayOfWeek.Tuesday:
        Console.WriteLine("Вівторок");
        break;
    case DayOfWeek.Wednesday:
        Console.WriteLine("Середа");
        break;
}*/


using _004_Enumerations;

double res1 = Product.CalculateTotalPrice(1000, Discount.Default);
Console.WriteLine(res1);
double res2 = Product.CalculateTotalPrice(1000, Discount.Middle);
Console.WriteLine(res2);
double res3 = Product.CalculateTotalPrice(1000, Discount.VIP);
Console.WriteLine(res3);




