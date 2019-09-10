using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPag152
{
    class MenuMaker
    {

        public Random Randomizer;

        string[] Meats = { "Carne assada ", "Salame ", "Peru ", "presunto ", "Pastrami " };

        string[] Condiments = { "Mostarda Amarela ", "mostarda marrom ", "mostarda de mel ", "maionese ", "saborear ", "vestido frânces " };

        string[] Breads = { "centeio ", "branco ", "trigo ", "pumpernickel ", "pão italiano ", "um rolo " };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " com " + randomCondiment + " dentro " + randomBread;
        }
    }
}

