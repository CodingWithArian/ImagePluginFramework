using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework
{
    public class ResizePlugin: IImagePlugin
    {
        public void Apply(ImageData image, Dictionary<string, object> parameters)
        {
            image.Width = (int)parameters["width"];
            image.Height = (int)parameters["height"];
            Console.WriteLine($"Resized {image.Name} to {image.Width}x{image.Height}");
        }
    }
}
