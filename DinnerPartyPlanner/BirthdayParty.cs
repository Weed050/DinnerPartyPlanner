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
        public bool CakeWritingToLong
        {
            get 
            {
                if(CakeWriting.Length > MaxWritingLenght())
                return true;
                else
                    return false;
            }
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal cost;
            if (FancyDecorations)
                cost = (NumberOfPeople * 15M) + 50M;
            else
                cost = (NumberOfPeople * 7.5M) + 30M;
            return cost;
        }
        public decimal Cost 
        {
            get 
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40M + (ActualLenght * .25M);
                else
                    cakeCost = 75M + (ActualLenght * .25M);
                return cakeCost+totalCost;
            }
        }
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            
            else
                return 40;
        }
        private int MaxWritingLenght()
        {
            if (CakeSize() == 8)
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
