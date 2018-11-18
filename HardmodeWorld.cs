using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EarlyHardmode
{
    class HardmodeWorld : ModWorld
    {
        public override void Initialize()
        {
            if (!Main.hardMode)
            {
                WorldGen.StartHardmode();
            }
        }
    }
}
