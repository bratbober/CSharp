namespace _012_PingPongEvents
{
    class Pong
    {
        public event EventHandler<PingPongEventArgs> EventPing;

        public void PingPong(object a, PingPongEventArgs pingPongEventArgs)
        {
            Console.WriteLine($"Pong recieve Ping {pingPongEventArgs.Count}");
            Thread.Sleep(500);
            pingPongEventArgs.Count += 1;
            EventPing?.Invoke(this, pingPongEventArgs);
        }
    }
}
