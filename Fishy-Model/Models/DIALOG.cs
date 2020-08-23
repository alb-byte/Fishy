using System;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Dialog :BaseModel
    {
        private int dialogId;
        private int user1Id;
        private int user2Id;
        private string userName;
        private string time;
        private string lastMessage;

        public Dialog(int dialogId, int userId, string userName, string time, string lastMessage)
        {
            this.DialogId = dialogId;
            this.UserId = userId;
            this.UserName = userName;
            this.Time = time;
            this.LastMessage = lastMessage;
        }
        public Dialog()
        {
        }
        public int DialogId
        {
            get { return dialogId; }
            set
            {
                dialogId = value;
                OnPropertyChanged("DialogId");
            }
        }
        public int UserId
        {
            get { return user1Id; }
            set
            {
                user1Id = value;
                OnPropertyChanged("UserId");
            }
        }
        public int User2Id
        {
            get { return user2Id; }
            set
            {
                user2Id = value;
                OnPropertyChanged("User2Id");
            }
        }
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public string Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }
        public string LastMessage
        {
            get { return lastMessage; }
            set
            {
                lastMessage = value;
                OnPropertyChanged("LastMessage");
            }
        }
        public override string ToString()
        {
            return $"Dialog_Id: {this.DialogId}\n" +
                $"User_Id: {this.UserId}\n" +
                $"User_Name: {this.UserName}\n" +
                $"Time: {this.Time}\n" +
                $"Last_Message: {this.LastMessage}\n";
        }

    }
}

