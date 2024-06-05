using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ImagePluginFramework
{
     class Program
    {
        static void Main(string[] args)
        {

            // Create image data
            // Create image data
            var image1 = new ImageData("Image1", new byte[] { });
            var image2 = new ImageData("Image2", new byte[] { });
            var image3 = new ImageData("Image3", new byte[] { });

            // Create and configure plugin manager
            var pluginManager = new PluginManager();
            pluginManager.RegisterPlugin("resize", new ResizePlugin());
            pluginManager.RegisterPlugin("blur", new BlurPlugin());
            pluginManager.RegisterPlugin("grayscale", new GrayscalePlugin());

            // Define effects for each image
            var effects1 = new List<Tuple<string, Dictionary<string, object>>>
            {
                Tuple.Create("resize", new Dictionary<string, object> { {"width", 100}, {"height", 100} }),
                Tuple.Create("blur", new Dictionary<string, object> { {"size", 2} })
            };

            var effects2 = new List<Tuple<string, Dictionary<string, object>>>
            {
                Tuple.Create("resize", new Dictionary<string, object> { {"width", 100}, {"height", 100} })
            };

            var effects3 = new List<Tuple<string, Dictionary<string, object>>>
            {
                Tuple.Create("resize", new Dictionary<string, object> { {"width", 150}, {"height", 150} }),
                Tuple.Create("blur", new Dictionary<string, object> { {"size", 5} }),
                Tuple.Create("grayscale", new Dictionary<string, object>())
            };

            // Apply effects
            pluginManager.ApplyEffects(image1, effects1);
            pluginManager.ApplyEffects(image2, effects2);
            pluginManager.ApplyEffects(image3, effects3);

            // Display the final state of images
            Console.WriteLine(image1);
            Console.WriteLine(image2);
            Console.WriteLine(image3);

           
        }
    }
}
