using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Each matchup entry
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// The winner(team) of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The match number of the matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
