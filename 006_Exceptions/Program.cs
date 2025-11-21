// Виключення(виняткові ситуації), Exceptions

// try, catch, finally, throw


/*try
{
    Console.WriteLine("Before Exception");
    throw new Exception("Test Exception");
    Console.WriteLine("After Exception");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("In finnaly block");
}*/


/*do
{
    try
    {
        int a = Convert.ToInt32(Console.ReadLine());

        if (a < 50)
            throw new Exception("out number should be >= 50");

        int b = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[5];
        arr[6] = 100;


        int res = a / b;
        Console.WriteLine($"Res: {res}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex) {
        Console.WriteLine(ex.Message);
    }
    catch(Exception ex) {
        Console.WriteLine(ex.Message);
    }                                  
}while (true);
*/


// Створення власних класів винятків

// Account
// Bank

/*using _006_Exceptions;

List<Account> accounts = new List<Account>()
{
    new Account {
        Id = 1,
        Name = "John",
        Surname = "Smith",
        Balance = 1000
    },
       new Account {
        Id = 2,
        Name = "Den",
        Surname = "Brown",
        Balance = 4343
    },
          new Account {
        Id = 3,
        Name = "Jack",
        Surname = "Snow",
        Balance = 6656
    }
};

Bank bank = new Bank(accounts);

Account account = new Account
{
    Id = 100,
    Name = "John",
    Surname = "Smith",
    Balance = 1000
};

try
{
    bank.Withdraw(account, 1000);
}
catch(NotFoundAccountException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Account.Id);
}*/





try
{
    Console.Write("Enter first num: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter sign: ");
    string b = Convert.ToString(Console.ReadLine());
    Console.Write("Enter second num: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int res = 0;
    switch (b)
    {
        case "+":
            res = a + c;
            Console.WriteLine(res);
            break;
        case "-":
            res = a - c;
            Console.WriteLine(res);
            break;
        case "*":
            res = a * c;
            Console.WriteLine(res);
            break;
        case "/":
            res = a / c;
            Console.WriteLine(res);
            break;
        default:
            break;
    }

}
catch(DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine(ex.Message);
}