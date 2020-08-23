using Fishy_Model.Request;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fishy.ViewModel.Network
{
    public abstract class NetworkTools
    {
        protected int port = int.Parse(ConfigurationManager.AppSettings["port"]);
        protected string server = ConfigurationManager.AppSettings["ip"];
        protected BinaryFormatter formatter = new BinaryFormatter();
    }
}
