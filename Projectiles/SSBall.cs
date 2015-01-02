using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class SSBall : ModProjectile
    {

        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(5) * 0.5f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(5) * 0.3f;
            int sp = ProjDef.byName["jFlail:SandProj"].type;
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 19, speedX, speedY, 80, default(Color), 1.4f);
            Main.dust[i].noGravity = false;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 18, speedX, speedY, 65, default(Color), 0.8f);
            Main.dust[j].noGravity = true;

            if (Main.rand.Next(1) == 0)
            {
                if (Main.rand.Next(10) == 0)
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY, sp, 9, 0, projectile.whoAmI);
            }
	    }
    }
}