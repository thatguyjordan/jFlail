using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class RPFBall : ModProjectile
    {

        public override void PostAI()
        {
		float speedX = projectile.velocity.X * (float)Main.rand.Next(5) * 0.5f;
		float speedY = projectile.velocity.Y * (float)Main.rand.Next(5) * 0.3f;
		int i = Dust.NewDust(projectile.position,projectile.width,projectile.height,60,speedX,speedY,80,default(Color),1.6f);
		Main.dust[i].noGravity = true;
		int j = Dust.NewDust(projectile.position,projectile.width,projectile.height,76,speedX,speedY,65,default(Color),0.8f);
		Main.dust[j].noGravity = true;
	    }
    }
}