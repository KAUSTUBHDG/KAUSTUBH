using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Equipments.Armors
{
    public class Armor
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get => this._armorPoints;
            set
            {
                if (value >= 0)
                {
                    this._armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }
    }
}
