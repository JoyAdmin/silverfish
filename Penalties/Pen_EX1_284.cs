// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_EX1_284.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ e x 1_284.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The pen_ e x 1_284.
    /// </summary>
    class Pen_EX1_284 : PenTemplate
	{
	    // azuredrake

// zauberschaden +1/. kampfschrei:/ zieht eine karte.
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