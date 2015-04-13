using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class GABall : ModProjectile
    {

        public override void PostAI()
        {
            float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
            float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;
            int sp = ProjDef.byName["jFlail:Starproj"].type;
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 29, speedX, speedY, 80, default(Color), 1.6f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 0, speedX, speedY, 65, default(Color), 0.8f);
            Main.dust[j].noGravity = true;

            if (Main.rand.Next(1) == 0)
            {
                if (Main.rand.Next(35) == 0)
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y + 1.0f, speedX, speedY, sp, 89, 0, projectile.whoAmI);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y + 1.0f, speedX, speedY, sp, 89, 0, projectile.whoAmI);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y + 1.0f, speedX, speedY, sp, 89, 0, projectile.whoAmI);
            }
        }
    }
}