using System;
using ConsoleApp1.Equipments.Interfaces;

namespace ConsoleApp1.Equipments.Weapons.Sharp
{
    public class Sword: Equipments.Weapons.Weapon,IBuff
    {

        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Sword(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAbility()
        {
            this.Buff();
        }

        public void Buff()
        {
            this.Bloodthirst();
        }
    }
}