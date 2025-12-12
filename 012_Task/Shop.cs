namespace _012_Task
{
    class Shop
    {
        public string ShopName { get; set; }

        public void YesNo(object a, ShopEventArgs shopExamArgs)
        {
            if(shopExamArgs.Age > 18){
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes");
                Console.ResetColor();
            }
            else{
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("No");
                Console.ResetColor();
            }
        }
    }
}
