using System;
using ConsoleApp1.Equipment.Armors.Leather;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipments.Weapons.Sharp;


namespace ConsoleApp1.Characters.Meele
{
    public class Assassin:Meele,IAttack,IDefend
    {

        private const string Nname = "Zabuza";
        private const string Ffaction = "SpellCaster";
        private static readonly LightLeatherVest BbodyArmor = new LightLeatherVest();
        private static readonly Sword Wweapon = new Sword();


        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private LightLeatherVest _bodyArmor;
        private Sword _weapon;



        public Assassin()
            : this(Nname, Llevel)
        {

        }

        public Assassin(string name, int level)
            : this(Nname, Llevel, Ffaction, AabilityPoints, BbodyArmor, Wweapon)
        {

        }

        public Assassin(string name, int level, string faction, int abilityPoints, LightLeatherVest bodyArmor, Sword weapon)
        {
            this._abilityPoints = abilityPoints;
            this._healthPoints = HhealthPoints;
            this._level = Llevel;
            this._faction = faction;
            this._name = Nname;
            this._bodyArmor = bodyArmor;
            this._weapon = weapon;
        }

        public int Raze()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }

        public override int Defend()
        {
            return this.Survival();
        }
    }
}
