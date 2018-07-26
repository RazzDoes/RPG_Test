using System;
namespace RPGTutorial
{
    public class MainGame
    {
		Hero myHero;
		Battle battle;
		string answer;

        public MainGame(){
			myHero = new Hero();
			Hero.Initailze(myHero);
			BasicGameLoop();
		}

		private void BasicGameLoop(){
			do{
				Monster monster = new Monster();
				battle = new Battle(myHero, monster);
				Console.WriteLine("Do you want to play again?");
				answer = Console.ReadLine();
			} while (answer == "Y" || answer == "y");
		}
    }
}
