using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritingHD
{
   public abstract class Character
    {
        private string _name;
        private int _health;
        private static int _count;

        public static int Count { get { return _count; } set { _count = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Health { get { return _health; } set { if (value < 0) { _health = 0; } else if (value > 100) { _health = 100; } else { _health = value; } } }
        public Character(string name)
        {
            Name = name;
            Health = 100;
            _count++;
        }
        
        public bool IsAlive()
        {
            return _health > 0;
        }
        public virtual bool TakeDamage(int amount)
        {
             if(!IsAlive()|| amount < 0)
            {
                return false;
            }
            Health -= amount;
            return true;
        }
        public bool TakeHeal(int amount)
        {
            if (!IsAlive() || amount < 0)
            {
                return false;
            }
            Health += amount;
            return true;
        }
        public virtual string GetDescription()
        {
            return $"{Name}, {Health}";
        }
        public virtual int AttackPower()
        {
            return 10;
        }
        public  bool Attack(Character target)
        {
            if(target.IsAlive()&& IsAlive())
            {
                target.TakeDamage(AttackPower());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
