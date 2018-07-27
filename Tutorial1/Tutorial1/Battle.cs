using System;
namespace RPGTutorial
{
    public class Battle
    {
		string userChoice;
		int damage;
		Random rand;

        public Battle(Hero hero, Monster monster){
			Console.WriteLine("{0} is facing a {1}.", hero.identifier, monster.identifier);
			BattleLoop(hero, monster);
        }

		public void BattleLoop(Hero hero, Monster monster){
			do{
				PrintStatus(hero, monster);
				userChoice = PrintChoice();
				Console.WriteLine();
				ProcessChoice(userChoice, hero, monster);
				monster.isAlive = CheckHealth(monster.currentHealth);
				Console.ReadLine();
				Console.Clear();
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

		string PrintChoice(){
			string choice;
			Console.WriteLine();
			Console.Write(@"
_____________________
Please choose an action:
(A)ttack:
(D)efend:
_____________________");
            Console.WriteLine();
            choice = Console.ReadLine();
            return choice;
        }

		void ProcessChoice(string choice, Hero hero, Monster monster){
			switch (choice){
				case "A":
				case "a":
					Console.WriteLine();
					Console.WriteLine("{0} attacks!", hero.identifier);
					DealDamage(hero, monster);
					monster.currentHealth -= damage;
					Console.WriteLine("{0} hits the {1} for {2}hp of damage", hero.identifier, monster.identifier, damage);
					break;
				case "D":
				case "d":
					Console.WriteLine();
					Console.WriteLine("{0} defends!", hero.identifier);
					break;
				default:
					Console.WriteLine("I'm sorry, I didn't recognize that.");
					Console.WriteLine();
					choice = PrintChoice();
					Console.WriteLine();
					ProcessChoice(choice, hero, monster);
					break;
			}
		}

		int DealDamage(Hero hero, Monster monster){
			int max;
			int min;
			rand = new Random();
			max = hero.attackDamage - monster.defense;

			if(max <= 0){
				max = 1;
			}

			min = (int)(hero.attackDamage * .8) - monster.defense;

			if(min <= 0){
				min = 1;
			}

			damage = rand.Next(min, max);
			return damage;
		}

		bool CheckHealth(int health){
			bool alive;
			if(health > 0){
				alive = true;
			} else {
				alive = false;
			}
			return alive;
		}
    }
}
