using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Unit
    {
        private float health = 100f; // поле здоровья, значение возвращается через свойство

        public string Name { get ; }
        public Interval Damage {  get; private set; }
        public float Armor { get;}

        public float Health
        {
            get { return this.health; }
        }


        public Unit(): this("Unknown unit") { }
           

        public Unit(string name)
        {
            this.Name = name;
            Damage = new Interval(0, 5);
            Armor = 0.6f;
            
        }

        public Unit(string name, int minDamage, int maxDamage)
        {
            if(minDamage < 0)
            {
                Console.WriteLine("Min Damage must be >= 0. Value was corrected to 0");
                minDamage = 0;

            }

            Damage = new Interval(minDamage, maxDamage);
        }


        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            health = health - value * Armor;

            if (Health <= 0f)
            {
                return true; //юнит погиб
            }
            return false; //юнит жив
        }

        

    }
}
