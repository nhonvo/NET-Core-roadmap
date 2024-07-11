using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (ClientWebSocket webSocket = new ClientWebSocket())
        {
            await webSocket.ConnectAsync(new Uri("ws://localhost:5000/ws"), CancellationToken.None);

            Console.WriteLine("Connected!");

            var sendBuffer = Encoding.UTF8.GetBytes("Hello from client");
            await webSocket.SendAsync(new ArraySegment<byte>(sendBuffer), WebSocketMessageType.Text, true, CancellationToken.None);

            var receiveBuffer = new byte[1024 * 4];
            WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);

            Console.WriteLine($"Received: {Encoding.UTF8.GetString(receiveBuffer, 0, result.Count)}");

            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
        }
    }
}
