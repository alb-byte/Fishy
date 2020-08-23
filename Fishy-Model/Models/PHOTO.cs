using System;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    [Serializable]
    public class Photo :BaseModel
    {
        private int id;
        private int album_id;
        private BitmapImage image;
        public Photo(int id, int album_id, BitmapImage bmp)
        {
            this.Id = id;
            this.Album_Id = album_id;
            this.Image = bmp;
        }
        public Photo()
        {
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
        public int Album_Id
        {
            get { return album_id; }
            set
            {
                album_id = value;
                OnPropertyChanged("Album_Id");
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
                $"Album_Id: {this.Album_Id}\n";
        }
    }
}
