namespace _012_Events
{
    class Handler1
    {

        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hander1: Counter has reached 50.");
            Console.ResetColor();
        }
    }
}
