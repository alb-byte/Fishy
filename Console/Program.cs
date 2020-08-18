using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static Fishy_Model.Request.Request;

namespace Cons
{
    class Program
    {
        static string server = "127.0.0.1";
        static int port = 8888;
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            Console.Read();
            client.Connect(server, port);
            NetworkStream stream = client.GetStream();
            USER u = new USER
            {
                FIRSTNAME = "Albert",
                LASTNAME = "Shy",
                EMAIL = "alasm@fd.com",
                PASS = "12345"
            };
            Request request = new Request(RequestType.GetUser, u);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, request);
            client.Close();


        }
    }
}
