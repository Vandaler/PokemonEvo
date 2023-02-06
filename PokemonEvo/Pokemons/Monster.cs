using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo 
{ 
    internal class Monster : Pokemon
    {
        public Monster()
        {
            this.Name = "Mons";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(800, 1294);
            this._image = Properties.Resources._005;
            this.Atk = random.Next(85, 174);
            this.Defense = random.Next(67, 185);
        }
    }
}
