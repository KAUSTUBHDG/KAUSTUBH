using System;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipment.Armors.Leather;
using ConsoleApp1.Equipments.Weapons.Sharp;

namespace ConsoleApp1.Characters.SpellCaster
{
    public class Necromancer: SpellCaster, IAttack,IDefend
    {
        private const string Nname = "Sauron";
        private const string Ffaction = "SpellCaster";
        
        private static readonly LightLeatherVest BbodyArmor = new LightLeatherVest();
        private static readonly Sword Wweapon = new Sword();


        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private LightLeatherVest _bodyarmor;
        private Sword _weapon;

        public Necromancer(LightLeatherVest bodyarmor)
            :this(Nname,Llevel, bodyarmor)
        {
          
        }

        public Necromancer(string name,int level, LightLeatherVest bodyarmor)
            : this(Nname,Llevel,Ffaction,Manapoints,BbodyArmor,Wweapon, bodyarmor)
        {
                
        }

        public Necromancer(string name,int level, string faction,int abilityPoints, LightLeatherVest bodyArmor, Sword weapon, LightLeatherVest bodyarmor)
        {
            this._abilityPoints = abilityPoints;
            this._healthPoints = HhealthPoints;
            this._level = Llevel;
            this._faction = faction;
            this._name = Nname;
            this.BodyArmor = bodyArmor;
            this.Weapon = weapon;
            _bodyarmor = bodyarmor;
        }
        
        public LightLeatherVest BodyArmor { get; set; }

        public Sword Weapon { get; set; }


        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
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
