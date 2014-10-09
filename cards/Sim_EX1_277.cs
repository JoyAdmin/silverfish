// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_277.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_277.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ e x 1_277.
    /// </summary>
    class Sim_EX1_277 : SimTemplate
	{
	    // arcanemissiles

// verursacht $3 schaden, der zufällig auf feindliche charaktere verteilt wird.

        /// <summary>
        /// The on card play.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="ownplay">
        /// The ownplay.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            // optimistic
            int i = 0;
            List<Minion> temp = ownplay ? p.enemyMinions : p.ownMinions;
            int times = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            if ((ownplay && p.enemyHero.Hp <= times) || (!ownplay && p.ownHero.Hp <= times))
            {
                if(ownplay) p.minionGetDamageOrHeal(p.enemyHero, p.enemyHero.Hp-1);
                else p.minionGetDamageOrHeal(p.ownHero, p.ownHero.Hp - 1);
            }
            else
            {
                while (i < times)
                {
                    if (temp.Count >= 1)
                    {
                        // search Minion with lowest hp
                        Minion enemy = temp[0];
                        int minhp = 10000;
                        bool found = false;
                        foreach (Minion m in temp)
                        {
                            if (m.name == CardDB.cardName.nerubianegg && enemy.Hp >= 2) continue; // dont attack nerubianegg!

                            if (m.Hp >= 1 && minhp > m.Hp)
                            {
                                enemy = m;
                                minhp = m.Hp;
                                found = true;
                            }
                        }

                        if (found)
                        {
                            p.minionGetDamageOrHeal(enemy, 1);
                        }
                        else
                        {
                            if (ownplay)
                                p.minionGetDamageOrHeal(p.enemyHero, 1);
                            else
                                p.minionGetDamageOrHeal(p.ownHero, 1);
                        }

                    }
                    else
                    {
                        if (ownplay)
                            p.minionGetDamageOrHeal(p.enemyHero, 1);
                        else
                            p.minionGetDamageOrHeal(p.ownHero, 1);
                    }

                    i++;
                }
            }
		}

	}
}