using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class MFBall : ModProjectile
    {
        public override void DealtNPC(NPC npc, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            float posY = projectile.position.Y - 500.0f;

            Projectile.NewProjectile(projectile.position.X, posY, 0, 14.4f, 9, 23, 0, projectile.whoAmI);
        }

        public override void DealtPVP(Player p, int hitDir, int dmgDealt, bool crit)
        {
            float posY = projectile.position.Y - 500.0f;

            Projectile.NewProjectile(projectile.position.X, posY, 0, 14.4f, 9, 23, 0, projectile.whoAmI);
        }

        public override void PostAI()
        {
		    float speedX = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
		    float speedY = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;

            if (Main.rand.Next(5) == 0)
            {
                int i = Dust.NewDust(projectile.position, projectile.width, projectile.height, 73, speedX, speedY, 45, default(Color), 1.0f);
                Main.dust[i].noGravity = false;
                int j = Dust.NewDust(projectile.position, projectile.width, projectile.height, 57, speedX, speedY, 25, default(Color), 0.8f);
                Main.dust[j].noGravity = true;
            }
	    }
    }
}