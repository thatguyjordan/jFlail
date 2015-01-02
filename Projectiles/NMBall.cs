using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class NMBall : ModProjectile
    {

        public override void PostAI()
        {
		float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.5f;
		float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.3f;

        if (Main.rand.Next(3) == 0)
            {
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 14, speedX, speedY, 50, default(Color), 1.2f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 27, speedX, speedY, 35, default(Color), 0.8f);
            Main.dust[j].noGravity = true;
            }
	    }
    }
}