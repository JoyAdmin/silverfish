// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_EX1_166.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ e x 1_166.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The pen_ e x 1_166.
    /// </summary>
    class Pen_EX1_166 : PenTemplate
	{
	    // keeperofthegrove

// wählt aus:/ verursacht 2 schaden; oder bringt einen diener zum schweigen/.
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