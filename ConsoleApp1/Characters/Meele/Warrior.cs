using System;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipments.Armors.Heavy;
using ConsoleApp1.Equipments.Weapons.Sharp;

namespace ConsoleApp1.Characters.Meele
{
    public class Warrior:Meele,IAttack,IDefend
    {
        private const string Nname = "Ceasar";
        private const string Ffaction = "SpellCaster";
       
        private static readonly Chainlink BbodyArmor = new Chainlink();
        private static readonly Axe Wweapon = new Axe();

        
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private Chainlink _bodyArmor;
        private Axe _weapon;

        public Warrior()
            : this(Nname, Llevel)
        {

        }

        public Warrior(string name, int level)
            : this(Nname, Llevel, Ffaction, AabilityPoints, BbodyArmor, Wweapon)
        {

        }

        public Warrior(string name, int level, string faction, int abilityPoints, Chainlink bodyArmor, Axe weapon)
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
            public Axe Weapon
            {
                get => this._weapon;
                set => this._weapon = value;
            }



            public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
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
