using Fishy.ViewModel.MainWindowVM;
using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Net.Sockets;
using System.Threading;

namespace Fishy.ViewModel.Network
{
    public class DifficultNetworkTool: NetworkTools
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private MainVM viewModel;
        public ResponseHandler ResponseHandler { get; set; }
        public void SendRequest(Request.RequestType type, object body)
        {
            Request request = new Request(type, body);
            formatter.Serialize(stream, request);
        }
        public void Connect(MainVM vm,User user)
        {
            viewModel = vm;
            client = new TcpClient();
            client.Connect(server, port); //подключение клиента
            stream = client.GetStream(); // получаем поток
            Request request = new Request(Request.RequestType.Connect, user);
            formatter.Serialize(stream,request);
            // запускаем новый поток для получения данных
            receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start(); //старт потока
            ResponseHandler = new ResponseHandler(vm);
        }
        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    Response response =(Response)formatter.Deserialize(stream);
                    ResponseHandler.Processing(response);
                }
                catch
                {
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }
        public void Disconnect()
        {
            try
            {
                receiveThread.Abort();
                if (stream != null)
                    stream.Close();//отключение потока
                if (client != null)
                    client.Close();//отключение клиента
            }
            catch { }
        }
    }
}
