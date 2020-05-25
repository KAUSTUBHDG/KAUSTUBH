using System;

namespace ConsoleApp1.Equipments.Armors.Heavy
{
    public class Chainlink:Armors.Armor
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}