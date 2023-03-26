using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner
{
    class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CostOfFoodPerPerson { get { return 25M; } }
        private string CakeWriting;
        public BirthdayParty(int numberOfPeople,bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
