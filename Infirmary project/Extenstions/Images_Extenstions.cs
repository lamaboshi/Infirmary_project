using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Infirmary_project.Extenstions {
   public class Images_Extenstions {

        public  BitmapImage ImagePicker() {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = " images |*.PNG; *.JPG; *.BMP";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Nullable<bool> result = of.ShowDialog();
            if (result == true) {
                return new BitmapImage(new Uri(of.FileName));
            }
            return null;
        }
        public static byte[] ConvertBitmapSourceToByteArray(ImageSource imageSource) {
            var image = imageSource as BitmapSource;
            byte[] data;
            BitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream()) {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
        public static BitmapImage ConvertByteArrayToBitmapImage(Byte[] bytes) {
            var stream = new MemoryStream(bytes);
            stream.Seek(0, SeekOrigin.Begin);
            var image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();
            return image;
        }
    }
}
