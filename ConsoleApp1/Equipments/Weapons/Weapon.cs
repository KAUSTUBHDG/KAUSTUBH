using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipments.Weapons
{
    public abstract class Weapon
    {
        private int _damage;

        public int DamagePoints
        {
            get => this._damage;
            set
            {
                if (value >= 0)
                {
                    this._damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public abstract void SpecialAbility();
    }
}
