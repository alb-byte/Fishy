using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    public class Server
    {
        static TcpListener tcpListener;
        List<Connection> clients = new List<Connection>(); // все подключения

        protected internal void AddConnection(Connection clientObject)
        {
            clients.Add(clientObject);
        }
        protected internal void RemoveConnection(int id)
        {
            // получаем по id закрытое подключение
            Connection client = clients.FirstOrDefault(c => c.Id == id);
            // и удаляем его из списка подключений
            if (client != null)
                clients.Remove(client);
        }
        protected internal void Listen()   // прослушивание входящих подключений
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, int.Parse(ConfigurationManager.AppSettings["port"]));//Any если несколько плат сетевых
                tcpListener.Start();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Сервер запущен...");
                Console.ResetColor();

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    Connection clientObject = new Connection(tcpClient, this);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }

        // трансляция сообщения клиен
        protected internal void SendResponse()
        {
            for (int i = 0; i < clients.Count; i++)
            {

            }
        }
        protected internal void SendResponse(int id)
        {
            for (int i = 0; i < clients.Count; i++)
            {

            }
        }
        // отключение всех клиентов
        protected internal void Disconnect()
        {
            tcpListener.Stop(); //остановка сервера

            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close(); //отключение клиента
            }
            Environment.Exit(0); //завершение процесса
        }
    }
}
