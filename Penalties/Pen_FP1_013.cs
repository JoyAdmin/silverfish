// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_FP1_013.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ f p 1_013.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The pen_ f p 1_013.
    /// </summary>
    class Pen_FP1_013 : PenTemplate
	{
	    // kelthuzad

// ruft am ende jedes zuges alle befreundeten diener herbei, die in diesem zug gestorben sind.
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