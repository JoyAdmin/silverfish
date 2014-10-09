// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS2_026.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 2_026.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ c s 2_026.
    /// </summary>
    class Sim_CS2_026 : SimTemplate
	{
	    // frostnova

// friert/ alle feindlichen diener ein.
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
            List<Minion> temp = ownplay ? p.enemyMinions : p.ownMinions;
            for (int i = 0; i < temp.Count; i++)
            {
                temp[i].frozen = true;
            }
		}

	}
}