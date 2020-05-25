using System;
using ConsoleApp1.Equipments.Interfaces;

namespace ConsoleApp1.Equipments.Weapons.Sharp
{
    public class Axe: Equipments.Weapons.Weapon,ISpecialAbility
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Axe(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAbility()
        {
            this.HackNSlash();
        }
    }
}
