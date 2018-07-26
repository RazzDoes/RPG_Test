using System;
namespace RPGTutorial
{
    public class Hero
    {
		public int currentHealth, maxHealth, currentMagic;
		public int maxMagic, strength, defense, agility;
		public int experience, gold, attackDamage;
		public string identifier;
		public bool isAlive;

        public Hero(){
        }

		public static void Initailze(Hero hero){
			hero.currentHealth = 18;
			hero.maxHealth = 18;
			hero.currentMagic = 8;
			hero.maxMagic = 8;
			hero.strength = 10;
			hero.defense = 3;
			hero.agility = 6;
			hero.experience = 0;
			hero.gold = 0;
			Console.WriteLine("What is your Hero's name?");
			hero.identifier = Console.ReadLine();
			hero.isAlive = true;
			hero.attackDamage = hero.strength;
		}
    }
}
