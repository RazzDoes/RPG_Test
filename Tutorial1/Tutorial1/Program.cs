using System;

namespace RPGTutorial {
    class Program {
        static void Main(string[] args){         
			int heroHitPoints, monsterHitPoints, attackDamage;
			string battleChoice;
			Random rand;

			heroHitPoints = 30;
			monsterHitPoints = 25;
			Console.WriteLine("You are facing a monster");

			do {
				rand = new Random();
				Console.Write(@"
*************************************************
Your hero has {0}hp and the monster has {1}hp
*************************************************", heroHitPoints, monsterHitPoints);
				Console.Write(@"
____________________________
Please Choose an action:
(A)ttack
(D)efend
____________________________");
				Console.WriteLine();
				battleChoice = Console.ReadLine();

				switch(battleChoice){
					case "a":
					case "A":
						attackDamage = rand.Next(3, 7);
						monsterHitPoints -= attackDamage;
						Console.WriteLine("The hero attacks!");
						Console.WriteLine("The monster loses {0}hp", attackDamage);
						break;
					case "d":
					case "D":
						Console.WriteLine("The hero defends!");
						break;
					default:
						Console.WriteLine("Sorry that choice was invalid and the monster takes a cheap shot");
						break;
				}

				Console.WriteLine();
				if(monsterHitPoints > 0){
					Console.WriteLine("The monster attacks!");
					attackDamage = rand.Next(3, 7);
					if(battleChoice == "d" || battleChoice == "D"){
						attackDamage /= 2;
					}
					heroHitPoints -= attackDamage;
					Console.WriteLine("The hero loses {0}hp", attackDamage);
				}
				Console.WriteLine("Press Enter to continue");
				Console.ReadLine();
				Console.Clear();
			} while (heroHitPoints > 0 && monsterHitPoints > 0);

			if(heroHitPoints > 0){
				Console.WriteLine("You have defeated the monster");
			} else {
				Console.WriteLine("The monster has defated you");
			}

            Console.ReadLine();
        }
    }
}
