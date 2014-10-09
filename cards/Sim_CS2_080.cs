// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS2_080.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 2_080.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The sim_ c s 2_080.
    /// </summary>
    class Sim_CS2_080 : SimTemplate
	{
	    // assassinsblade

        /// <summary>
        /// The w.
        /// </summary>
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_080);

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
            p.equipWeapon(this.w, ownplay);
        }

	}
}