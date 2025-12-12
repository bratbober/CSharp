namespace _012_Events
{
    class Handler2
    {

        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Handler2: Ура вже половина!!!.");
            Console.ResetColor();
        }
    }
}
