using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class CCBall : ModProjectile
    {

        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.7f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(2) * 0.2f;
            if (Main.rand.Next(1) == 0)
            {
                if (Main.rand.Next(30) == 0)
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY, 410, 16, 0, projectile.whoAmI); //non homing bubble
                //Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY, 405, 9, 0, projectile.whoAmI); homing bubble
                int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 41, speedX, speedY, 80, default(Color), 1.4f);
                Main.dust[i].noGravity = true;
            }
	    }
    }
}