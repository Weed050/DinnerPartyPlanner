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
        public string CakeWriting { get; set; }
        private int ActualLenght { get 
            {
                if (CakeWriting.Length > MaxWritingLenght())
                {
                    return MaxWritingLenght();
                }
                else { return CakeWriting.Length; }
            }}
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            
            else
                return 40;
        }
        private int MaxWritingLenght()
        {
            if (CakeSize() == 20)
                return 16;
            else
                return 40;
        }
        public BirthdayParty(int numberOfPeople,bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
