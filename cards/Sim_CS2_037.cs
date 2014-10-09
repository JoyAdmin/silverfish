// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS2_037.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 2_037.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ c s 2_037.
    /// </summary>
    class Sim_CS2_037 : SimTemplate
	{
	    // frostshock

// fügt einem feindlichen charakter $1 schaden zu und friert/ ihn ein.
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
            int dmg = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            target.frozen = true;
            p.minionGetDamageOrHeal(target, dmg);
            
		}

	}
}