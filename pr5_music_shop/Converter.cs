using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_music_shop
{
    internal class Converter
    {
        public static T DeserializeObject<T>()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                string json = File.ReadAllText(ofd.FileName);
                T obj = jsonConvert.DeserializeObject<T>();
            }
        }
    }
}
