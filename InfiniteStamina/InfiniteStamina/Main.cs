using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteStamina
{
    public class Main : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("InfiniteStamina has been loaded");

            UnturnedPlayerEvents.OnPlayerUpdateStamina += OnStaminaUpdated;
        }

        protected override void Unload()
        {
            Logger.Log("InfiniteStamina has been unloaded");

            UnturnedPlayerEvents.OnPlayerUpdateStamina -= OnStaminaUpdated;
        }

        private void OnStaminaUpdated(UnturnedPlayer player, byte stamina)
        {
            if (stamina != 100)
                player.Player.life.serverModifyStamina(100);
        }
    }
}
