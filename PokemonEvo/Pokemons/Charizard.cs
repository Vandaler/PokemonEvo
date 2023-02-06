using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo
{
    internal class Charizard : Pokemon
    {
        public Charizard()
        {
            Name = "Charizard";
            Random random = new Random();
            HP = random.Next(266, 360);
            _image = Properties.Resources._006;
            Atk = random.Next(155, 293);
            Defense = random.Next(144, 280);
        }
    }
}
