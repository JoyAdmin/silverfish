// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS1_129.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 1_129.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ c s 1_129.
    /// </summary>
    class Sim_CS1_129 : SimTemplate
	{
	    // innerfire

// setzt den angriff eines dieners auf einen wert, der seinem leben entspricht.
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
            p.minionSetAngrToHP(target);
		}

	}
}