using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace Fishy_Model.Models
{
    public abstract class BaseModel:INotifyPropertyChanged
    {
        public static Bitmap BitmapImageToBitmap(BitmapImage bitmapImage)
        {
            if (bitmapImage != null)
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    BitmapEncoder enc = new BmpBitmapEncoder();
                    enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                    enc.Save(outStream);
                    Bitmap bitmap = new Bitmap(outStream);

                    return new Bitmap(bitmap);
                }
            }
            return null;
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        public static BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                using (var memory = new MemoryStream())
                {
                    bitmap.Save(memory, ImageFormat.Png);
                    memory.Position = 0;

                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = memory;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze();

                    return bitmapImage;
                }
            }
            return null;
        }

        public static byte[] EncodeImage(BitmapImage Image)
        {
            if (Image != null)
            {
                Bitmap bitmap = BitmapImageToBitmap(Image);
                using (MemoryStream mstream = new MemoryStream())
                {
                    bitmap.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return mstream.ToArray();
                }
            }
            return null;
        }
        public static BitmapImage DecodeImage(byte[] imageByteArray)
        {
            if (imageByteArray != null)
            {
                MemoryStream ms = new MemoryStream(imageByteArray);
                Image bitmap = Bitmap.FromStream(ms);
                return BitmapToBitmapImage((Bitmap)bitmap);
            }
            return null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
