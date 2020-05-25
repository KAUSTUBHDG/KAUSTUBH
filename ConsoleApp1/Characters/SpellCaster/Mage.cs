using System;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipments.Armors.Light;
using ConsoleApp1.Equipments.Weapons.Blunt;

namespace ConsoleApp1.Characters.SpellCasters
{
    public class Mage:SpellCaster.SpellCaster, IAttack,IDefend
    {


        private const string Nname = "Yoda";
        private const string Ffaction = "SpellCaster";
        
        private static readonly ClothRobe BbodyArmor = new ClothRobe();
        private static readonly Staff Wweapon = new Staff();


        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private ClothRobe _bodyArmor;
        private Staff _weapon;

        public Mage()
            : this(Nname, Llevel)
        {

        }

        public Mage(string name, int level)
            : this(Nname, Llevel, Ffaction, Manapoints, BbodyArmor, Wweapon)
        {

        }

        public Mage(string name, int level, string faction, int abilityPoints, ClothRobe bodyArmor, Staff weapon)
        {
            this._abilityPoints = abilityPoints;
            this._healthPoints = HhealthPoints;
            this._level = Llevel;
            this._faction = faction;
            this._name = Nname;
            this._bodyArmor = bodyArmor;
            this._weapon = weapon;
        }

        

        public ClothRobe BodyArmor
        {
            get => this._bodyArmor;
            set => this._bodyArmor = value;
        }
        public Staff Weapon
        {
            get => this._weapon;
            set => this._weapon = value;
        }



        public void Fireball()
        {
            throw new NotImplementedException();
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
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
