using System;
namespace RPGTutorial
{
    public class Monster
    {
		Random rand;
		protected int aiAttack, aiDefend, aiSpell;
		public int currentHealth, maxHealth, currentMagic;
		public int maxMagic, strength, defense, agility;
		public int experience, gold, attackDamage;
		public string identifier;
		public bool isAlive;

        public Monster(){
			aiAttack = 90;
			aiDefend = 100;
			aiSpell = 0;

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

		public string AI(){
			string choice;
			int aiNumberChoice;
			rand = new Random();
			aiNumberChoice = rand.Next(1, 100);
			if(aiNumberChoice < aiAttack){
				choice = "Attack";
			} else if (aiNumberChoice <= aiDefend && aiNumberChoice >= aiAttack){
				choice = "Defend";
			} else if (aiNumberChoice < aiSpell && aiNumberChoice > aiDefend){
				choice = "Spell";
			} else{
				choice = "Flee";
			}
			return choice;
		}
    }
}
