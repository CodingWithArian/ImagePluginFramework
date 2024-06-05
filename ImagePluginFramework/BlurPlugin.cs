using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework
{
    public class BlurPlugin: IImagePlugin
    {
        public void Apply(ImageData image, Dictionary<string, object> parameters)
        {
            image.BlurSize = (int)parameters["size"];
            Console.WriteLine($"Applied blur of size {image.BlurSize} to {image.Name}");
        }
    }
}
