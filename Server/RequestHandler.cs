using Fishy_Model.Models;
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
        private GenericUnitOfWork db;

        public RequestHandler()
        {
            this.db = new GenericUnitOfWork();
        }
        public Response Processing(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Type)
                {
                    case Request.RequestType.CreateAlbum:
                        {
                            db.Albums.Create((ALBUM)request.Body);
                            break;
                        }
                    case Request.RequestType.GetAlbum:
                        {
                            db.Albums.GetEntity(a => a.Equals((ALBUM)request.Body));
                            break;
                        }
                    case Request.RequestType.GetAlbums:
                        {
                            db.Albums.Get();
                            break;
                        }
                    case Request.RequestType.UpdateAlbum:
                        {
                            db.Albums.Update((ALBUM)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteAlbum:
                        {
                            db.Albums.Remove((ALBUM)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateComment:
                        {
                            db.Comments.Create((COMMENT)request.Body);
                            break;
                        }
                    case Request.RequestType.GetComment:
                        {
                            db.Comments.GetEntity(c => c.Equals((COMMENT)request.Body));
                            break;
                        }
                    case Request.RequestType.GetComments:
                        {
                            db.Comments.Get();
                            break;
                        }
                    case Request.RequestType.UpdateComment:
                        {
                            db.Comments.Update((COMMENT)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteComment:
                        {
                            db.Comments.Remove((COMMENT)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateDialog:
                        {
                            db.Dialogs.Create((DIALOG)request.Body);
                            break;
                        }
                    case Request.RequestType.GetDialog:
                        {
                            db.Dialogs.GetEntity(d => d.Equals((DIALOG)request.Body));
                            break;
                        }
                    case Request.RequestType.GetDialogs:
                        {
                            db.Dialogs.Get();
                            break;
                        }
                    case Request.RequestType.UpdateDialog:
                        {
                            db.Dialogs.Update((DIALOG)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteDialog:
                        {
                            db.Dialogs.Remove((DIALOG)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateFish:
                        {
                            db.Fishes.Create((FISH)request.Body);
                            break;
                        }
                    case Request.RequestType.GetFish:
                        {
                            db.Fishes.GetEntity(f => f.Equals((FISH)request.Body));
                            break;
                        }
                    case Request.RequestType.GetFishes:
                        {
                            db.Fishes.Get();
                            break;
                        }
                    case Request.RequestType.UpdateFish:
                        {
                            db.Fishes.Update((FISH)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteFish:
                        {
                            db.Fishes.Remove((FISH)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateFriend:
                        {
                            db.Friends.Create((FRIEND)request.Body);
                            break;
                        }
                    case Request.RequestType.GetFriend:
                        {
                            db.Friends.GetEntity(f => f.Equals((FRIEND)request.Body));
                            break;
                        }
                    case Request.RequestType.GetFriends:
                        {
                            db.Friends.Get();
                            break;
                        }
                    case Request.RequestType.UpdateFriend:
                        {
                            db.Friends.Update((FRIEND)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteFriend:
                        {
                            db.Friends.Remove((FRIEND)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateMessage:
                        {
                            db.Messages.Create((MESSAGE)request.Body);
                            break;
                        }
                    case Request.RequestType.GetMessage:
                        {
                            db.Messages.GetEntity(m => m.Equals((MESSAGE)request.Body));
                            break;
                        }
                    case Request.RequestType.GetMessages:
                        {
                            db.Messages.Get();
                            break;
                        }
                    case Request.RequestType.UpdateMessage:
                        {
                            db.Messages.Update((MESSAGE)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteMessage:
                        {
                            db.Messages.Remove((MESSAGE)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateNews:
                        {
                            db.News.Create((NEWS)request.Body);
                            break;
                        }
                    case Request.RequestType.GetNews:
                        {
                            db.News.Get();
                            break;
                        }
                    case Request.RequestType.UpdateNews:
                        {
                            db.News.Update((NEWS)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteNews:
                        {
                            db.News.Remove((NEWS)request.Body);
                            break;
                        }

                    case Request.RequestType.CreatePhoto:
                        {
                            db.Photos.Create((PHOTO)request.Body);
                            break;
                        }
                    case Request.RequestType.GetPhoto:
                        {
                            db.Photos.GetEntity(p => p.Equals((PHOTO)request.Body));
                            break;
                        }
                    case Request.RequestType.GetPhotos:
                        {
                            db.Photos.Get();
                            break;
                        }
                    case Request.RequestType.UpdatePhoto:
                        {
                            db.Photos.Update((PHOTO)request.Body);
                            break;
                        }
                    case Request.RequestType.DeletePhoto:
                        {
                            db.Photos.Remove((PHOTO)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateStateInspection:
                        {
                            db.StateInspections.Create((STATE_INSPECTION)request.Body);
                            break;
                        }
                    case Request.RequestType.GetStateInspection:
                        {
                            db.StateInspections.GetEntity(s => s.Equals((STATE_INSPECTION)request.Body));
                            break;
                        }
                    case Request.RequestType.GetStateInspections:
                        {
                            db.StateInspections.Get();
                            break;
                        }
                    case Request.RequestType.UpdateStateInspection:
                        {
                            db.StateInspections.Update((STATE_INSPECTION)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteStateInspection:
                        {
                            db.StateInspections.Remove((STATE_INSPECTION)request.Body);
                            break;
                        }

                    case Request.RequestType.CreateUser:
                        {
                            db.Users.Create((USER)request.Body);
                            break;
                        }
                    case Request.RequestType.GetUser:
                        {
                            USER user = (USER)request.Body;
                            response.Body = db.Users.GetEntity(u => u.EMAIL.Equals(user.EMAIL) && u.PASS.Equals(user.PASS));
                            break;
                        }
                    case Request.RequestType.GetUsers:
                        {
                            db.Users.Get();
                            break;
                        }
                    case Request.RequestType.UpdateUser:
                        {
                            db.Users.Update((USER)request.Body);
                            break;
                        }
                    case Request.RequestType.DeleteUser:
                        {
                            db.Users.Remove((USER)request.Body);
                            break;
                        }
                }
            }
            catch
            {
                response.State = Response.ResponseState.Error;
            }
            db.Save();
            return response;
        }
    }
}
