using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Comment :BaseModel,IDataErrorInfo
    {
        private int id;
        private int photo_id;
        private int owner_id;
        private string owner_name;
        private BitmapImage owner_photo;
        private string text;

        public Comment(int id, int photo_id, int owner_id, string owner_name, BitmapImage bmp, string text)
        {
            this.Id = id;
            this.Photo = photo_id;
            this.Owner = owner_id;
            this.Owner_Name = owner_name;
            this.Image = bmp;
            this.Text = text;
        }
        public Comment()
        {
            this.Text = String.Empty;
        }
        public Comment(Comment c)
        {
            this.Text = c.Text;
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
        public int Owner
        {
            get { return owner_id; }
            set
            {
                owner_id = value;
                OnPropertyChanged("Owner_Id");
            }
        }
        public int Photo
        {
            get { return photo_id; }
            set
            {
                photo_id = value;
                OnPropertyChanged("Photo_Id");
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
        public BitmapImage Image
        {
            get { return owner_photo; }
            set
            {
                owner_photo = value;
                OnPropertyChanged("Owner_Photo");
            }
        }
        public string Owner_Name
        {
            get { return owner_name; }
            set
            {
                owner_name = value;
                OnPropertyChanged("Owner_Name");
            }
        }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Text":
                        {
                            if (Text.Length > 100)
                            {
                                error = "Превышена длинна комментария";
                            }
                            break;
                        }
                    case "Id":
                        {
                            if (Id < 0)
                            {
                                error = "Идентификатор комментария не может быть меньше 0";
                            }
                            break;
                        }
                    case "Owner_Id":
                        {
                            if (Owner < 0)
                            {
                                error = "Идентификатор владельца комментария не может быть меньше 0";
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
                $"Photo_Id: {this.Photo}\n" +
                $"Owner_id: {this.Owner}\n" +
                $"Owner_Name: {this.Owner_Name}\n" +
                $"Text: {this.Text}";
        }

    }
}