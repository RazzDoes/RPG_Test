using System;
namespace RPGTutorial
{
    public class Battle
    {
        public Battle(Hero hero, Monster monster){
			Console.WriteLine("{0} is facing a {1}.", hero.identifier, monster.identifier);
			BattleLoop(hero, monster);
        }

		public void BattleLoop(Hero hero, Monster monster){
			do{
				PrintStatus(hero, monster);
				Console.ReadLine();
			} while (hero.isAlive == true && monster.isAlive == true);
		}

		public void PrintStatus(Hero hero, Monster monster){
			Console.Write(@"
********************************
         HP/MaxHP   MP/MaxMP
{0}:   {1}/{2}hp    {3}/{4}mp
{5}: {6}/{7}hp      {8}/{9}mp
********************************", hero.identifier, hero.currentHealth, hero.maxHealth, hero.currentMagic, hero.maxMagic, monster.identifier, monster.currentHealth, monster.maxHealth, monster.currentMagic, monster.maxMagic);
        }
    }
}
