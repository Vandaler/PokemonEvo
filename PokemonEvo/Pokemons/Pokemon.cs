﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvo
{
    public class Pokemon
    {
        protected string Name;
        protected int HP;
        protected int Atk;
        protected int Speed;
        protected int Defense;
        protected Bitmap _image;

        public Bitmap getImage()
        {
            return _image;
        }
        public string getName()
        {
            return Name;
        }
        public int getHP()
        {
            return HP;
        }
        public int getAtk() { return Atk; }
        public int getSpeed() { return Speed; }
        public int getDefense() { return Defense; }
        public void takeDamage(int damage) {
            if (damage > 0)
            {
                HP -= damage;
            }
            else
            {
                HP = 0;
            }
            
        }

    }

}