using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo
{
    internal class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Random random = new Random();
            Name = "Pikachu";
            HP = random.Next(180, 274);
            _image = Properties.Resources._025;
            Atk = random.Next(103, 229);
            Defense = random.Next(76, 196);
        }
    }
}
