using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Connection
    {
        protected internal int Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        private TcpClient client;
        private Server server;
        private BinaryFormatter BinaryFormatter;

        public Connection(TcpClient tcpClient, Server serverObject)
        {
            client = tcpClient;
            server = serverObject;
            BinaryFormatter = new BinaryFormatter();
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                // получаем id пользователя которое и будет id подключения
                this.Id = ((USER)BinaryFormatter.Deserialize(Stream)).ID;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(Id + " подключился");
                Console.ResetColor();
                Request request = null;
                while (true)
                {
                    try
                    {
                        request = (Request)BinaryFormatter.Deserialize(Stream);

                        server.SendResponse();
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{Id}: отключился");
                        Console.ResetColor();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
