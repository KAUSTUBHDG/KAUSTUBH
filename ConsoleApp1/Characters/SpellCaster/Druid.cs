using ConsoleApp1.Equipment.Armors.Leather;
using System;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipments.Weapons.Blunt;

namespace ConsoleApp1.Characters.SpellCasters
{
    public class Druid:SpellCaster.SpellCaster,IAttack,IDefend
    {

        private const string Nname = "Merlin";
        private const string Ffaction = "SpellCaster";
       
        private static readonly LightLeatherVest BbodyArmor = new LightLeatherVest();
        private static readonly Staff Wweapon = new Staff();


        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private LightLeatherVest _bodyArmor;
        private Staff _weapon;

        public Druid()
            : this(Nname, Llevel)
        {

        }

        public Druid(string name, int level)
            : this(Nname, Llevel, Ffaction, Manapoints, BbodyArmor, Wweapon)
        {

        }

        public Druid(string name, int level, string faction, int abilityPoints, LightLeatherVest bodyArmor, Staff weapon)
        {
            this._abilityPoints = abilityPoints;
            this._healthPoints = HhealthPoints;
            this._level = Llevel;
            this._faction = faction;
            this._name = Nname;
            this._bodyArmor = bodyArmor;
            this._weapon = weapon;
        }


     

        public LightLeatherVest BodyArmor
        {
            get => _bodyArmor;
            set => _bodyArmor = value;
        }
        public Staff Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }


        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
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
