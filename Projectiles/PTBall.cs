using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class PTBall : ModProjectile
    {

        public override void PostKill()
        {
            float speedX = projectile.velocity.X;
            float speedY = projectile.velocity.Y;
            int sp = ProjDef.byName["jFlail:Meteoroid"].type;
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 29, speedX, speedY, 80, default(Color), 1.6f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 0, speedX, speedY, 65, default(Color), 0.8f);
            Main.dust[j].noGravity = true;
            Projectile.NewProjectile(projectile.position.X + 3.0f, projectile.position.Y + 1.0f, speedX, speedY, sp, 51, 0, projectile.whoAmI);
            Projectile.NewProjectile(projectile.position.X + 8.0f, projectile.position.Y + 2.0f, speedX, speedY, sp, 51, 0, projectile.whoAmI);
            }
        }
    }
}