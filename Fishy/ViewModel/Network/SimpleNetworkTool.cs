using FISHY.View.Resources.UserControls.MyMessageBox;
using Fishy_Model.Request;
using System;
using System.Net.Sockets;

namespace Fishy.ViewModel.Network
{
    public class SimpleNetworkTool:NetworkTools
    {
        public Response SendRequest(Request.RequestType type, object body)
        {
            Response response = null;
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();
                Request request = new Request(type, body);
                formatter.Serialize(stream, request);
                response = (Response)formatter.Deserialize(stream);
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message, App.Current.Windows[0]);
            }
            return response;
        }
    }
}
