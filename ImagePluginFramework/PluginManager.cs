using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ImagePluginFramework
{
    public class PluginManager
    {
        private Dictionary<string, IImagePlugin> _plugins = new Dictionary<string, IImagePlugin>();

        public void RegisterPlugin(string name, IImagePlugin plugin)
        {
            _plugins[name] = plugin;
        }

        public void ApplyEffects(ImageData image, List<Tuple<string, Dictionary<string, object>>> effects)
        {
            foreach (var effect in effects)
            {
                if (_plugins.ContainsKey(effect.Item1))
                {
                    _plugins[effect.Item1].Apply(image, effect.Item2);
                }
            }
        }
    }
}
