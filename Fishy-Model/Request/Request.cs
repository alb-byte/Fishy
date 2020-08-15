using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishy_Model.Request
{
    [Serializable]
    public class Request
    {
        public RequestType Type { get; set; }
        public object Body { get; set; }
        public Request(RequestType type, object body)
        {
            this.Type = type;
            this.Body = body;
        }
        public enum RequestType 
        {
            CreateUser = 1,
            GetUser,
            GetUsers,
            UpdateUser,
            DeleteUser,

            CreateAlbum,
            GetAlbum,
            GetAlbums,
            UpdateAlbum,
            DeleteAlbum,

            CreateComment,
            GetComment,
            GetComments,
            UpdateComment,
            DeleteComment,

            CreateDialog,
            GetDialog,
            GetDialogs,
            UpdateDialog,
            DeleteDialog,

            CreateFish,
            GetFish,
            GetFishes,
            UpdateFish,
            DeleteFish,

            CreateFriend,
            GetFriend,
            GetFriends,
            UpdateFriend,
            DeleteFriend,

            CreateMessage,
            GetMessage,
            GetMessages,
            UpdateMessage,
            DeleteMessage,

            CreateNews,
            GetNews,
            UpdateNews,
            DeleteNews,

            CreatePhoto,
            GetPhoto,
            GetPhotos,
            UpdatePhoto,
            DeletePhoto,

            CreateStateInspection,
            GetStateInspection,
            GetStateInspections,
            UpdateStateInspection,
            DeleteStateInspection
        }

    }
}
