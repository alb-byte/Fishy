using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    [Serializable]
    public class News : BaseModel, IDataErrorInfo
    {
        private int id;
        private string title;
        private string text;
        private string time;
        private BitmapImage image;
        public News(int id, string title, string text, BitmapImage img)
        {
            this.Id = id;
            this.Title = title;
            this.Text = text;
            this.Image = img;
        }
        public News()
        {
            this.Title = String.Empty;
            this.Text = String.Empty;
            this.Time = String.Empty;
        }
        public News(News news)
        {
            this.Title = news.Title;
            this.Text = news.Text;
            this.Image = news.Image;
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
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
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
        public BitmapImage Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }
        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"Title: {this.Title}\n" +
                $"Text: {this.Text}";
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
                                error = "Идентификатор новости не может быть меньше 0";
                            }
                            break;
                        }
                    case "Image":
                        {
                            if (Image == null)
                            {
                                error = "Фото должно быть добавлено";
                            }
                            break;
                        }
                    case "Title":
                        {
                            if (Title.Length > 20)
                            {
                                error = "Превышена длинна заголовка";
                            }
                            break;
                        }
                    case "Text":
                        {
                            if (Text.Length > 400)
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
    }
}
