using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal  Cost 
        { get 
            { 
            decimal cost = 0;
             cost +=   CalculateCostOfBeveragesPerPerson();
                cost += CalculateCostOfBeveragesPerPerson();
                cost += NumberOfPeople * 25M;
                if (HealthyOption)
                {
                    cost *= 0.95M;
                }
                return cost;
            }  
        }

        public DinnerParty(int numberOfPeople,bool healthyOption,bool fancyDecoration)
        {
            this.NumberOfPeople = numberOfPeople;
            this.HealthyOption = healthyOption;
            this.FancyDecorations = fancyDecoration;
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal cost = 0;
            if (FancyDecorations)
            {
                cost = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                cost = (NumberOfPeople * 7.5M) + 30M;
            }
            return cost;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal cost = 0;
            if (HealthyOption)
            {
                cost = NumberOfPeople * 5M;
            }
            else
            {
                cost = NumberOfPeople * 20M;
            }
            return cost;
        }

    }
}
