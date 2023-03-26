using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyPlanner
{
    public class DinnerParty
    {
        public int NumberOfPeople;
        public bool FancyDecorations;
        public bool HealthyOption;
        decimal Cost = 0M;

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy) 
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {

            decimal totalCost = CostOfDecorations+ ((CostOfBeveragesPerPerson + CostOfFoodPerPerson ) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost *= 0.95M;
            }
            else { return totalCost; }
        }
        
    }
}
