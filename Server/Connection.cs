using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        private RequestHandler requestHandler;

        public Connection(TcpClient tcpClient, Server serverObject)
        {
            client = tcpClient;
            server = serverObject;
            requestHandler = new RequestHandler();
            BinaryFormatter = new BinaryFormatter();
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                Response response = new Response();
                while (true)
                {
                    try
                    {
                        Request request = (Request)BinaryFormatter.Deserialize(Stream);
                        if(request.Type == Request.RequestType.Connect )
                        {
                            this.Id = ((User)request.Body).Id;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"{Id}: подключился");
                            Console.ResetColor();
                            response.State = Response.ResponseState.NotNull;
                        }
                        else
                        {
                            response = requestHandler.Processing(request);
                        }
                        server.SendResponse(response,this);
                    }
                    catch(DbUpdateException ex)
                    {
                        server.SendResponse(new Response(),this);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{Id}: отключился");
                        Console.ResetColor();
                        server.RemoveConnection(this.Id);
                        Close();
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
