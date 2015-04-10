using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jFlail.Projectiles
{
    public class BFastBall : ModProjectile
    {

        public override void DealtNPC(NPC npc, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            int c1 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c2 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c3 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c4 = ProjDef.byName["jFlail:CerealPiece"].type;
            float speedX = projectile.velocity.X;
            float speedY = projectile.velocity.Y;
            float speedX2 = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
            float speedY2 = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;
           
            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY, c1, 5, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(4) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX2, speedY, c4, 4, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(6) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY2, c2, 7, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX2, speedY2, c3, 7, 0, projectile.whoAmI);
            }
	    }
        public override void DealtPVP(Player p, int hitDir, int dmgDealt, bool crit)
        {
            int c1 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c2 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c3 = ProjDef.byName["jFlail:CerealPiece"].type;
            int c4 = ProjDef.byName["jFlail:CerealPiece"].type;
            float speedX = projectile.velocity.X;
            float speedY = projectile.velocity.Y;
            float speedX2 = projectile.velocity.X * (float)Main.rand.Next(3) * 0.2f;
            float speedY2 = projectile.velocity.Y * (float)Main.rand.Next(3) * 0.2f;

            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY, c1, 5, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(4) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX2, speedY, c4, 4, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(6) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX, speedY2, c2, 7, 0, projectile.whoAmI);
            }
            if (Main.rand.Next(3) == 0)
            {
                Projectile.NewProjectile(projectile.position.X + 9.0f, projectile.position.Y + 9.0f, speedX2, speedY2, c3, 7, 0, projectile.whoAmI);
            }
        }
    }
}