using System;
using System.Text;
using System.Net.Sockets;
using RiotAPIFrontEnd;
using System.IO;
using Newtonsoft.Json;
using Models.Summoner;
namespace Core
{
    public class Main
    {
        TcpClient client;
        StreamWriter writer;
        MainPage window;
        NetworkStream stream;
        StreamReader reader;
        public Main(MainPage m)
        {
            window = m;
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            //client.Receive(bytes);
            // m.setText(Encoding.UTF8.GetString(bytes));
            //  Console.WriteLine(client.Receive(bytes));
        }
        public T convertToJson<T>(String jsonObject)
        {
            return JsonConvert.DeserializeObject<T>(jsonObject);

        }
        public void receiveSummoner()
        {
            String receive = reader.ReadLine();
            Summoner s = JsonConvert.DeserializeObject<Summoner>(receive);
            //window.ShowSummoner(s);
        }
        public String receiveMessage()
        {
            return reader.ReadLine();
        }
        public void sendMessage(String message)
        {
            writer.WriteLine(message);
            //window.setText(message);
            writer.Flush();
        }
    }
}
