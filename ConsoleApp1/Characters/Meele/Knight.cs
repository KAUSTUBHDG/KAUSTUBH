using System;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipment.Armors.Leather;
using ConsoleApp1.Equipments.Armors.Heavy;
using ConsoleApp1.Equipments.Weapons.Blunt;

namespace ConsoleApp1.Characters.Meele
{
    public class Knight:Meele,IAttack,IDefend
    {
        private const string Nname = "Fury";
        private const string Ffaction = "SpellCaster";
        
        private static readonly Chainlink BbodyArmor = new Chainlink();
        private static readonly Hammer Wweapon = new Hammer();


        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private Chainlink _bodyArmor;
        private Hammer _weapon;


        public Knight()
            : this(Nname, Llevel)
        {

        }

        public Knight(string name, int level)
            : this(Nname, Llevel, Ffaction, AabilityPoints, BbodyArmor, Wweapon)
        {

        }

        public Knight(string name, int level, string faction, int abilityPoints, Chainlink bodyArmor, Hammer weapon)
        {
            this._abilityPoints = abilityPoints;
            this._healthPoints = HhealthPoints;
            this._level = Llevel;
            this._faction = faction;
            this._name = Nname;
            this._bodyArmor = bodyArmor;
            this._weapon = weapon;
        }

    
            public Chainlink BodyArmor
            {
                get => this._bodyArmor;
                set => this._bodyArmor = value;
            }
            public Hammer Weapon
            {
                get => this._weapon;
                set => this._weapon = value;
            }


        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
