using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Numeric position of each of the finalists
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// position in words of the finalists
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
