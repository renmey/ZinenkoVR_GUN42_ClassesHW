using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Unit
    {
        private float health = 100f; // поле здоровья, значение возвращается через свойство

        public string Name { get ; }
        public int Damage {  get; }
        public float Armor { get;}

        public float Health
        {
            get { return this.health; }
        }


        public Unit(): this("Unknown unit") { }
           

        public Unit(string name)
        {
            this.Name = name;
            Damage = 5;
            Armor = 0.6f;
            
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
