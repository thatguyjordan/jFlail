using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class CSBall : ModProjectile
    {

        public override void PostKill()
        {
            float speedX = projectile.velocity.X * 0.5f;
            float speedY = projectile.velocity.Y * (float)Main.rand.Next(2) * 0.3f;
            int sp = ProjDef.byName["jFlail:SporeCloud"].type;
            int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 2, speedX, speedY, 80, default(Color), 1.6f);
            Main.dust[i].noGravity = true;
            int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 44, speedX, speedY, 65, default(Color), 0.8f);
            Main.dust[j].noGravity = true;
            Projectile.NewProjectile(projectile.position.X + 3.0f, projectile.position.Y + 1.0f, speedX, speedY, sp, 35, 0, projectile.whoAmI);
            }
        }
    }
}