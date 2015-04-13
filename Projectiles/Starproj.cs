using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class Starproj : ModProjectile
    {
        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;
            {
                int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 63, speedX, speedY, 5, default(Color), 1.5f);
                Main.dust[i].noGravity = true;
                int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 57, speedX, speedY, 5, default(Color), 1.9f);
                Main.dust[j].noGravity = true;
            }
	    }
    }
}