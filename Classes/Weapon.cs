using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Weapon
    {
        public string Name { get; }
        public Interval Damage  { get; private set; }
        
        public float Durability { get; }

        const int F = 1; //минимальный урон оружия


        public Weapon(string Name)
        {
            this.Name = Name;
            Durability = 1;
        }

        public Weapon(string Name, int MinDamage, int MaxDamage) : this(Name)
        {

            SetDamageParams(MinDamage, MaxDamage);

        }


        public void SetDamageParams(int MinDamage, int MaxDamage)
        {
           Damage = new Interval(MinDamage, MaxDamage);

        }

        public int GetDamage()
        {
            return Damage.Get ; // вместо среднего арифметического теперь оружие наносит случайный урон в своем диапазоне
        }




    }
}
