// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_NEW1_003.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ ne w 1_003.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ ne w 1_003.
    /// </summary>
    class Sim_NEW1_003 : SimTemplate
	{
	    // sacrificialpact

// vernichtet einen dämon. stellt bei eurem helden #5 leben wieder her.
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
            p.minionGetDestroyed(target);
            int heal = ownplay ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
            if (ownplay)
            {
                p.minionGetDamageOrHeal(p.ownHero, -heal);
            }
            else
            {
                p.minionGetDamageOrHeal(p.enemyHero, -heal);
            }
		}

	}
}