using _012_PingPongEvents;

Ping ping = new Ping();
Pong pong = new Pong();
PingPongEventArgs pingPongEventArgs = new PingPongEventArgs();
ping.EventPong += pong.PingPong;
pong.EventPing += ping.PingPong;
ping.PingPong(null, new PingPongEventArgs { Count = 0 });
