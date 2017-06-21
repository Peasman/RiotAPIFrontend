using System;
using System.Text;
using System.Net.Sockets;

namespace RiotAPIFrontend
{
    class Main
    {
        TcpClient client;
        //TextWriter writer;
        NetworkStream stream;
        public Main(MainPage m)
        {
            client = new TcpClient();
            stream = client.GetStream();

            //client.Receive(bytes);
            // m.setText(Encoding.UTF8.GetString(bytes));
            //  Console.WriteLine(client.Receive(bytes));
        }
        public void sendMessage(String message)
        {
            byte[] toBytes = Encoding.UTF8.GetBytes(message);
            stream.Write(toBytes,0,toBytes.Length);
        }
    }
}
