using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using ConsoleApp1.Characters.Interfaces;
using ConsoleApp1.Equipments.Weapons;

namespace ConsoleApp1.Characters
{
    public abstract class Character:IAttack,IDefend
    {
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        public bool _isAlive = true;
        private string _faction;
        private string _name;
        public int _scores;


        public int AbilityPoints
        {
            get => this._abilityPoints;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this._abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
        }
        public int HealthPoints
        {
            get => this._healthPoints;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this._healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
        public int Level
        {
            get => this._level;
            set
            {
                if (value >= 0)
                {
                    this._level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public string Name
        {
            get => this._name;
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this._name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }

        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();

        public void TakeDamage(int damge, string attackname, string type)
        {
            if (this.Defend() < damge)
            {
                this._healthPoints = this._healthPoints - damge;

                if (_healthPoints == 0)
                {
                    this._isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("I am stronger than your attacks!!!!");
            }

            if (!this._isAlive)
            {
                switch (type)
                {
                    case "ConsoleApp1.Characters.Meele.Assassin":
                        Console.WriteLine(this._name+" received "+damge+" to "+attackname+" and now he is dead!!! "+type);
                        break;
                    case "ConsoleApp1.Characters.Meele.Warrior":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and now he is dead!!! " + type);
                        break;
                    case "ConsoleApp1.Characters.Meele.Knight":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and now he is dead!!! " + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Druid":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and now he is dead!!! " + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Mage":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and now he is dead!!! " + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Necromancer":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and now he is dead!!! " + type);
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "ConsoleApp1.Characters.Meele.Assassin":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are"+this._healthPoints + type);
                        break;
                    case "ConsoleApp1.Characters.Meele.Warrior":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are" + this._healthPoints + type);
                        break;
                    case "ConsoleApp1.Characters.Meele.Knight":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are" + this._healthPoints + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Druid":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are" + this._healthPoints + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Mage":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are" + this._healthPoints + type);
                        break;
                    case "ConsoleApp1.Characters.SpellCaster.Necromancer":
                        Console.WriteLine(this._name + " received " + damge + " to " + attackname + " and his HP are" + this._healthPoints + type);
                        break;
                }
            }
        }

    

        public void WonBattle()
        {
            this._scores++;
            if (_scores % 10 == 0)
            {
                this._level++;
            }
        }


    }

    
}