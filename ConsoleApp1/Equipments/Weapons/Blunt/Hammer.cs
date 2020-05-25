using System;
using ConsoleApp1.Equipments.Interfaces;

namespace ConsoleApp1.Equipments.Weapons.Blunt
{
    public class Hammer:Equipments.Weapons.Weapon,ISpecialAbility
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Hammer()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }

        public Hammer(int armorPoints)
        {
            this.DamagePoints = armorPoints;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }


        public override void SpecialAbility()
        {
            this.Stun();
        }
    }
}