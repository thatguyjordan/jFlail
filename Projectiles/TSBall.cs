using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class TSBall : ModProjectile
    {
        public override void DealtPVP(Player p, int hitDir, int dmgDealt, bool crit)
        {
            p.AddBuff(20, 60, false);
        }
        public override void DealtNPC(NPC n, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            n.AddBuff(20, 60, false);
        }
        public override void PostAI()
        {
		float speedX = projectile.velocity.X * (float)Main.rand.Next(5) * 0.5f;
		float speedY = projectile.velocity.Y * (float)Main.rand.Next(5) * 0.3f;

        if (Main.rand.Next(3) == 0)
            {
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 18, speedX, speedY, 80, default(Color), 1.4f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 3, speedX, speedY, 65, default(Color), 0.8f);
            Main.dust[j].noGravity = true;
            }
	    }
    }
}