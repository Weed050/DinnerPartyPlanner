using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner
{
    public class DinnerParty
    {
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecoration;
        }
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal CostOfFoodPerPerson { get { return 25M; } }
        public decimal Cost
        {
            get
            {
                decimal cost = 0;
                cost = CalculateCostOfDecorations();
                cost += NumberOfPeople * (CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson);
                if (HealthyOption)
                {
                    cost = cost * 0.95M;
                }
                return cost;
            }
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal cost = 0;
            if (FancyDecorations)
            {
                cost = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                cost = (NumberOfPeople * 7.50M) + 30.00M;
            }
            return cost;
        }
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal cost = 0;
            if (HealthyOption)
            {
                cost = NumberOfPeople * 5.00M;
            }
            else
            {
                cost = NumberOfPeople * 20.00M;
            }
            return cost;
        }

    }
}
