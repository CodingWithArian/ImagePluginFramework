using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagePluginFramework
{
    public interface IImagePlugin
    {
        void Apply(ImageData image, Dictionary<string, object> parameters);
    }
}
