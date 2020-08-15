using Fishy_Model.Request;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class RequestHandler
    {
        private Request request;
        private GenericUnitOfWork db;

        public RequestHandler(Request request)
        {
            this.request = request;
            this.db = new GenericUnitOfWork();
        }
        public object Processing()
        {
            switch (request.Type)
            {
                case Request.RequestType.CreateAlbum:
                    {
                        
                        break;
                    }
                case Request.RequestType.GetAlbum:
                    {

                        break;
                    }
                case Request.RequestType.GetAlbums:
                    {

                        break;
                    }
                case Request.RequestType.UpdateAlbum:
                    {

                        break;
                    }
                case Request.RequestType.DeleteAlbum:
                    {

                        break;
                    }

                case Request.RequestType.CreateComment:
                    {

                        break;
                    }
                case Request.RequestType.GetComment:
                    {

                        break;
                    }
                case Request.RequestType.GetComments:
                    {

                        break;
                    }
                case Request.RequestType.UpdateComment:
                    {

                        break;
                    }
                case Request.RequestType.DeleteComment:
                    {

                        break;
                    }

                case Request.RequestType.CreateDialog:
                    {

                        break;
                    }
                case Request.RequestType.GetDialog:
                    {

                        break;
                    }
                case Request.RequestType.GetDialogs:
                    {

                        break;
                    }
                case Request.RequestType.UpdateDialog:
                    {

                        break;
                    }
                case Request.RequestType.DeleteDialog:
                    {

                        break;
                    }

                case Request.RequestType.CreateFish:
                    {

                        break;
                    }
                case Request.RequestType.GetFish:
                    {

                        break;
                    }
                case Request.RequestType.GetFishes:
                    {

                        break;
                    }
                case Request.RequestType.UpdateFish:
                    {

                        break;
                    }
                case Request.RequestType.DeleteFish:
                    {

                        break;
                    }

                case Request.RequestType.CreateFriend:
                    {

                        break;
                    }
                case Request.RequestType.GetFriend:
                    {

                        break;
                    }
                case Request.RequestType.GetFriends:
                    {

                        break;
                    }
                case Request.RequestType.UpdateFriend:
                    {

                        break;
                    }
                case Request.RequestType.DeleteFriend:
                    {

                        break;
                    }

                case Request.RequestType.CreateMessage:
                    {

                        break;
                    }
                case Request.RequestType.GetMessage:
                    {

                        break;
                    }
                case Request.RequestType.GetMessages:
                    {

                        break;
                    }
                case Request.RequestType.UpdateMessage:
                    {

                        break;
                    }
                case Request.RequestType.DeleteMessage:
                    {

                        break;
                    }

                case Request.RequestType.CreateNews:
                    {

                        break;
                    }
                case Request.RequestType.GetNews:
                    {

                        break;
                    }
                case Request.RequestType.UpdateNews:
                    {

                        break;
                    }
                case Request.RequestType.DeleteNews:
                    {

                        break;
                    }

                case Request.RequestType.CreatePhoto:
                    {

                        break;
                    }
                case Request.RequestType.GetPhoto:
                    {

                        break;
                    }
                case Request.RequestType.GetPhotos:
                    {

                        break;
                    }
                case Request.RequestType.UpdatePhoto:
                    {

                        break;
                    }
                case Request.RequestType.DeletePhoto:
                    {

                        break;
                    }

                case Request.RequestType.CreateStateInspection:
                    {

                        break;
                    }
                case Request.RequestType.GetStateInspection:
                    {

                        break;
                    }
                case Request.RequestType.GetStateInspections:
                    {

                        break;
                    }
                case Request.RequestType.UpdateStateInspection:
                    {

                        break;
                    }
                case Request.RequestType.DeleteStateInspection:
                    {

                        break;
                    }

                case Request.RequestType.CreateUser:
                    {

                        break;
                    }
                case Request.RequestType.GetUser:
                    {

                        break;
                    }
                case Request.RequestType.GetUsers:
                    {

                        break;
                    }
                case Request.RequestType.UpdateUser:
                    {

                        break;
                    }
                case Request.RequestType.DeleteUser:
                    {

                        break;
                    }
            }
            return new object();
        }
    }
}
