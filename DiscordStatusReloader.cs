using Oxide.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("Discord Status Reloader", "Oryx", "1.0.0")]
    [Description("Reloads Discord Status when its stops responding")]

    public class DiscordStatusReloader : RustPlugin
    {
        private float reload_in_seconds = 1800;

        void Init()
        {
            timer.Every(reload_in_seconds, () =>
            {
                rust.RunServerCommand("o.reload DiscordStatus");
            });
        }
    }
}
