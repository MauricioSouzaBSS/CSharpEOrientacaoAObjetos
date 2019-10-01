using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanejadorDeFesta
{
    class BirthdayParty
    {

        public  const int CostOfFoodPerPerson = 25;

        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        public decimal CakeSize;
        public string CakeWriting;


        private void CalculateCakeSize()
        {

        }
        
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {

            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }
        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;
            return TotalCost + CakeCost;
        }
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
        public void CalculateCostOfDecorations(bool fancy) {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

       
            
    }
}
