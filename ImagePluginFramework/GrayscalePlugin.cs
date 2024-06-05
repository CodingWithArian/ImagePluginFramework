using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework
{
    public class GrayscalePlugin: IImagePlugin
    {
        public void Apply(ImageData image, Dictionary<string, object> parameters)
        {
            image.IsGrayscale = true;
            Console.WriteLine($"Converted {image.Name} to grayscale");
        }
    }
}
