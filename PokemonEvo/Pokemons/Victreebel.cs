using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo
{
    internal class Victreebel : Pokemon
    {
        
        public Victreebel()
        {
            Random random = new Random();
            Name = "Victreebel";
            HP = random.Next(270, 364);
            _image = Properties.Resources._069;
            Atk = random.Next(193, 339);
            Defense = random.Next(121, 251);
        }
    }
}
