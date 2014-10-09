// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_102.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_102.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ e x 1_102.
    /// </summary>
    class Sim_EX1_102 : SimTemplate
	{
	    // demolisher

// fügt zu beginn eures zuges einem zufälligen feind 2 schaden zu.

        /// <summary>
        /// The on turn start trigger.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="triggerEffectMinion">
        /// The trigger effect minion.
        /// </param>
        /// <param name="turnStartOfOwner">
        /// The turn start of owner.
        /// </param>
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                List<Minion> temp2 = turnStartOfOwner? p.enemyMinions : p.ownMinions;
                bool dmgdone = false;
                foreach (Minion mins in temp2)
                {
                    p.minionGetDamageOrHeal(mins, 2);
                    dmgdone = true;
                    break;
                }

                if (!dmgdone)
                {
                    if (turnStartOfOwner) { p.minionGetDamageOrHeal(p.enemyHero, 2); } else { p.minionGetDamageOrHeal(p.ownHero, 2); }
                };
            }
        }

	}
}