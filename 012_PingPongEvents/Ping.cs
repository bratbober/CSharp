namespace _012_PingPongEvents
{
    class Ping
    {
        public event EventHandler<PingPongEventArgs> EventPong;
        public void PingPong(object a, PingPongEventArgs pingPongEventArgs)
        {
            Console.WriteLine($"Pong recieve Pong {pingPongEventArgs.Count}");
            Thread.Sleep(500);
            pingPongEventArgs.Count += 1;
            EventPong?.Invoke(this, pingPongEventArgs);
        }

    }
}
