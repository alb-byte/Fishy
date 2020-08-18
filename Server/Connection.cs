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
        private State state;
        private TcpClient client;
        private Server server;
        private BinaryFormatter BinaryFormatter;
        private RequestHandler requestHandler;

        public Connection(TcpClient tcpClient, Server serverObject)
        {
            client = tcpClient;
            server = serverObject;
            requestHandler = new RequestHandler();
            BinaryFormatter = new BinaryFormatter();
            state = State.NOTAUTHORIZED;
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                Response response = null;
                while (true)
                {
                    try
                    {
                        Request request = (Request)BinaryFormatter.Deserialize(Stream);
                        response = requestHandler.Processing(request);
                        if(request.Type == Request.RequestType.GetUser && state == State.NOTAUTHORIZED && 
                            response.State != Response.ResponseState.IsNull )
                        {
                            state = State.AUTHORIZED;
                            this.Id = ((USER)response.Body).ID;
                        }
                        server.SendResponse(response,this);
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

        private enum State
        {
            AUTHORIZED,
            NOTAUTHORIZED
        }
    }
}
