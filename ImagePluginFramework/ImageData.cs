using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework
{
    public class ImageData
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int BlurSize { get; set; }
        public bool IsGrayscale { get; set; }

        public ImageData(string name, byte[] data)
        {
            Name = name;
            Data = data;
            Width = 0;
            Height = 0;
            BlurSize = 0;
            IsGrayscale = false;
        }

        public override string ToString()
        {
            return $"Image: {Name}, Width: {Width}, Height: {Height}, BlurSize: {BlurSize}, IsGrayscale: {IsGrayscale}";
        }
    }
}
