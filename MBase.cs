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
    public sealed class MBase : ModBase
    {
        internal static MBase BaseInstance;
        public override void OnLoad() 
        {
            BaseInstance = this;
            Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chain3"];
        }
        public override void OnUnload()
        {
            Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chain3"];
        }
    }
}