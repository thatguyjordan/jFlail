using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class BCBall : ModProjectile
    {

        public override void DealtNPC(NPC npc, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            float speedY = projectile.velocity.Y;
            projectile.velocity.Y = speedY - (float)Main.rand.Next(3) * 0.2f;
        }
    }
}