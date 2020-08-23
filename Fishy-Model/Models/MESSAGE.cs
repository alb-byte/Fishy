using System;
using System.ComponentModel;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Message :BaseModel,IDataErrorInfo
    {
        private int id;
        private int sender_id;
        private int handler_id;
        private string text;
        private string time;
        private int dialogId;

        public Message(int id, string text, string time)
        {
            this.Id = id;
            this.Text = text;
            this.Time = time;
        }
        public Message(Message m)
        {
            this.Text = m.Text;
        }
        public Message()
        {
            this.Text = String.Empty;
        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
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
        public int SenderId
        {
            get { return sender_id; }
            set
            {
                sender_id = value;
                OnPropertyChanged();
            }
        }
        public int HandlerId
        {
            get { return handler_id; }
            set
            {
                handler_id = value;
                OnPropertyChanged();
            }
        }
        public int DialogId
        {
            get { return dialogId; }
            set
            {
                dialogId = value;
                OnPropertyChanged();
            }
        }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Id":
                        {
                            if (Id < 0)
                            {
                                error = "Идентификатор сообщения не может быть меньше 0";
                            }
                            break;
                        }

                    case "Text":
                        {
                            if (Text.Length > 120)
                            {
                                error = "Превышена длинна текста";
                            }
                            break;
                        }
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"Time: {this.Time}\n" +
                $"Text: {this.Text}";
        }
    }
}
