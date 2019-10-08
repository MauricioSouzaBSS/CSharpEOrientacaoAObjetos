using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoDeFestas2
{
    class BirthdayParty
    {
        
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;
        public int CakeSize;

        private bool fancyDecorations;
        private string cakeWriting = "";
        private int numberOfPeople;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;  // 
            CalculateCakeSize();
            this.cakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }
        private void CalculateCakeSize()  // calcular tamanho das letras do bolo
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }
       
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set       // estudar esse metodo do set com muitas coisas que eu nao tinha visto antes
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Muitas Letras para um Bolo de " + CakeSize);
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }
        public decimal CalculateCost ()   // calcular o custo das decorações + de comida e numero de pessoas
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * numberOfPeople);
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + cakeWriting.Length * .25M;
            else
                CakeCost = 75M + cakeWriting.Length * .25M;
            return TotalCost + CakeCost;
        }

        
        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }
    }
}
