// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS2_084.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 2_084.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ c s 2_084.
    /// </summary>
    class Sim_CS2_084 : SimTemplate
	{
	    // huntersmark

// setzt das leben eines dieners auf 1.
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
            p.minionSetLifetoOne(target);
		}

	}
}