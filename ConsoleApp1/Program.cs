using System;
using System.Collections.Generic;
using System.Dynamic;
using ConsoleApp1.Characters;
using ConsoleApp1.Characters.Meele;
using ConsoleApp1.Characters.SpellCaster;
using ConsoleApp1.Characters.SpellCasters;

namespace ConsoleApp1
{
    class EntryPoint
    {
        static void Main()
        {
            bool gameOver = false;

            Random rng = new Random();

            Meele currentMelee;
            SpellCaster currentSpellcaster;

            List<Meele> meleeTeam = new List<Meele>();
            List<SpellCaster> spellTeam = new List<SpellCaster>();

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            foreach (var character in characters)
            {
                if (character is Meele)
                {
                    meleeTeam.Add((Meele)character);
                }
                else if (character is SpellCaster)
                {
                    spellTeam.Add((SpellCaster)character);
                }
            }

            PlayersInfo.Initialize(characters);


            PlayersInfo.Initialize(characters);

            while (!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (!currentSpellcaster._isAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                       Console.WriteLine("\nMelee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                    }
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());

                if (!currentMelee._isAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("\nSpell team wins!", ConsoleColor.Red);

                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }

            PlayersInfo.UpdateFullInfo(characters);
            PlayersInfo.Save(characters);
            PlayersInfo.PrintFullInfo();

        }
    }
}
