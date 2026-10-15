using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingHD
{
    public class Mage : Character
    {
        private int _mana;
        public int Mana { get { return _mana; } set { if( value < 0) { _mana = 0; } else { _mana = value; } } }
        public Mage(string name, int mana) : base(name)
        {
            Mana = mana;
        }
        public override string GetDescription()
        {
            return base.GetDescription() +"mana " +Mana;
        }
        public override int AttackPower()
        {
            if (Mana >= 10) {
                Mana -= 10;
                return 30;
            }
            else
            {
                return base.AttackPower();
            }
        }
    }
}
