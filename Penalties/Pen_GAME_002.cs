// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_GAME_002.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ gam e_002.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The pen_ gam e_002.
    /// </summary>
    class Pen_GAME_002 : PenTemplate
	{
	    // avatarofthecoin

// i&gt;ihr habt den münzwurf verloren, aber einen freund gewonnen./i&gt;
        /// <summary>
        /// The get play penalty.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="m">
        /// The m.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        /// <param name="isLethal">
        /// The is lethal.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
		{
		return 0;
		}

	}
}