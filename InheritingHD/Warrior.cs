using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingHD
{
    public class Warrior : Character
    {
        private int _armor; 
        public int Armor { get { return _armor; } set { if (value < 0) { _armor = 0; } else { _armor = value; } } }
        public Warrior(string name, int armor) : base(name)
        {
            Armor = armor;
        }
        public override bool TakeDamage(int amount)
        {
            return base.TakeDamage(amount - Armor);
        }
        public override string GetDescription()
        {
            return base.GetDescription() +"-armor" + Armor;
        }
        
    }

}
