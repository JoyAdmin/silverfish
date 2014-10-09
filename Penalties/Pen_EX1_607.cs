// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pen_EX1_607.cs" company="">
//   
// </copyright>
// <summary>
//   The pen_ e x 1_607.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    /// The pen_ e x 1_607.
    /// </summary>
    class Pen_EX1_607 : PenTemplate
	{
	    // innerrage

// fügt einem diener $1 schaden zu. der diener erhält +2 angriff.
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
            if (target.own)
            {
                if (m.Hp == 1)
                {
                    return 500;
                }

                if (!m.Ready)
                {
                    return 50;
                }
            }
            else
            {
                // if (m.handcard.card.type == CardDB.cardtype.MOB && p.ownMinions.Count == 0) return 0;
                // allow it if you have biggamehunter
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.name == CardDB.cardName.biggamehunter || hc.card.name == CardDB.cardName.shadowworddeath)
                    {
                        return 0;
                    }
                }

                if (m.Hp == 1)
                {
                    return 0;
                }

                if (!m.wounded && (m.Angr >= 4 || m.Hp >= 5))
                {
                    foreach (Handmanager.Handcard hc in p.owncards)
                    {
                        if (hc.card.name == CardDB.cardName.execute)
                        {
                            return 0;
                        }
                    }
                }

                return this.getValueOfMinion(4, 5);
            }

            return 0;
		}

	}
}