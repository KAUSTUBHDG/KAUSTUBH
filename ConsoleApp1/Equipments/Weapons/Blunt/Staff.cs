using System;
using ConsoleApp1.Equipments.Interfaces;

namespace ConsoleApp1.Equipments.Weapons.Blunt
{
    public class Staff : Equipments.Weapons.Weapon, IBuff
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Staff(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }


        public override void SpecialAbility()
        {
            this.Buff();
        }

        public void Buff()
        {
            this.Empower();
        }
    }
}