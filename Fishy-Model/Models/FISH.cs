using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Fish :BaseModel, IDataErrorInfo
    {
        private int id;
        private string name;
        private string description;
        private BitmapImage image;

        public Fish(int id, string name, string discription, BitmapImage img)
        {
            this.Id = id;
            this.Name = name;
            this.Description = discription;
            this.Image = img;
        }
        public Fish(Fish fish)
        {
            this.Name = fish.Name;
            this.Image = fish.Image;
            this.Description = fish.Description;
        }
        public Fish()
        {
            this.Name = String.Empty;
            this.Description = String.Empty;
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
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Discription");
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
                                error = "Идентификатор рыбы не может быть меньше 0";
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
                    case "Name":
                        {
                            if (Name.Length > 15)
                            {
                                error = "Превышена длинна заголовка";
                            }
                            break;
                        }
                    case "Discription":
                        {
                            if (Description.Length > 400)
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
                $"Name: {this.Name}\n" +
                $"Discription: {this.Description}";
        }
    }
}
