using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo
{
    internal class Acanine : Pokemon
    {
        public Acanine()
        {
            Random random = new Random();
            Name = "Pikachu";
            HP = random.Next(290, 384);
            _image = Properties.Resources._059;
            Atk = random.Next(202, 350);
            Defense = random.Next(148, 284);
        }
    }
}
