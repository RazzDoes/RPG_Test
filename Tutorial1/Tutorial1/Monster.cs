using System;
namespace RPGTutorial
{
    public class Monster
    {
		public int currentHealth, maxHealth, currentMagic;
		public int maxMagic, strength, defense, agility;
		public int experience, gold, attackDamage;
		public string identifier;
		public bool isAlive;

        public Monster(){
			currentHealth = 8;
			maxHealth = 8;
			currentMagic = 0;
			maxMagic = 0;
			strength = 5;
			defense = 3;
			agility = 4;
			experience = 5;
			gold = 2;
			identifier = "Monster";
			isAlive = true;
			attackDamage = strength;
        }
    }
}
