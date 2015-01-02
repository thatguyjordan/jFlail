using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class SandProj : ModProjectile
    {
        public override void AI()
        {
            projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.5f;
        }
        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 19, speedX, speedY, 1, default(Color), 1.1f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 18, speedX, speedY, 1, default(Color), 0.7f);
            Main.dust[j].noGravity = true;
	    }
    }
}