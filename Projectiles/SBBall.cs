using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class SBBall : ModProjectile
    {

        public override void PostAI()
        {
		float speedX = projectile.velocity.X * (float)Main.rand.Next(5) * 0.5f;
		float speedY = projectile.velocity.Y * (float)Main.rand.Next(5) * 0.3f;

        int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 76, 0.0f, 1.9f, 15, default(Color), 0.8f);
        Main.dust[i].noGravity = false;
            if (Main.rand.Next(3) == 0)
            {
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 16, speedX, speedY, 35, default(Color), 0.5f);
            Main.dust[j].noGravity = true;
            }
	    }
    }
}