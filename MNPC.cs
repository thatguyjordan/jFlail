using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using TAPI;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace jFlail
{
    [GlobalMod]
    public sealed class MNPC : ModNPC
    {
        public override void PostNPCLoot()
        {
            int ss = ItemDef.byName["jFlail:String Shot"].type;
            int X = (int)npc.position.X;
            int Y = (int)npc.position.Y;
            if ((npc.type == 164  || npc.type == 165) && Main.rand.Next(33) == 0)
            {
                Item.NewItem(X, Y, npc.width, npc.height, ss, 1, false, 0, false);
            }
            int pt = ItemDef.byName["jFlail:The Planetoid"].type;
            if ((npc.type == 284) && Main.rand.Next(33) == 0)
            {
                Item.NewItem(X, Y, npc.width, npc.height, pt, 1, false, 0, false);
            }
        }
    }
}