using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail
{
    public class Webbed : ModBuff
    {
        public override void Effects(Player player, int index)
        {
            player.velocity.X = player.velocity.X / 2.5f; ;
            player.velocity.Y = player.velocity.Y / 1.2f;
        }
        public override void Effects(NPC npc, int index)
        {
            npc.velocity.X = npc.velocity.X / 2.5f;
            npc.velocity.Y = npc.velocity.Y / 1.2f;
        }
    }
}