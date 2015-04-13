using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;


namespace jFlail
{
    public sealed class MPlayer : ModPlayer
    {
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void MidUpdate()
        {
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Yellow Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Yellow Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Green Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Green Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Red Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Red Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Blue Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Blue Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:White Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/White Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Purple Phaseflail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Purple Phaseflail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Wooden Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Wooden Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Palm Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Palm Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Boreal Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Boreal Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Rich Mahogany Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Rich Mahogany Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Ebonwood Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Ebonwood Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Shadewood Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Shadewood Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Pearlwood Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Pearlwood Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Copper Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Copper Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Tin Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Tin Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Iron Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Iron Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Lead Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Lead Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Silver Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Silver Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Tungsten Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Tungsten Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Gold Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Gold Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Platinum Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Platinum Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:String Shot"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/String Shot Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Coral Crusher"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Coral Crusher Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:The Stinger"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/The Stinger Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Nightmare"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Nightmare Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:The Snowball"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/The Snowball Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Pumpkin Masher"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Pumpkin Masher Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Moonfury"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Moonfury Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Skull And Bones"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Skull And Bones Chain"];
            }    
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Adamantite Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Adamantite Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Chlorophyte Crusher"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chlorophyte Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Chlorophyte Smasher"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chlorophyte Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Cobalt Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Cobalt Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Hallowed Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Hallowed Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Mythril Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Mythril Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Palladium Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Palladium Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Orichalcum Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Orichalcum Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:The Balanced Breakfast"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/The Balanced Breakfast Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Titanium Flail"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Titanium Flail Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:The Planetoid"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Meteor Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:Ball and Chain"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Grapple Chain"];
            }
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jFlail:The Galaxy"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Galactic Chain"];
            }
        }
    }
}