using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class Game
    {
        //Member Variables (HAS A)
        public Player player1;
        public Player player2;
        public List<string> rules;


        //Constructor (SPAWNER)
        public Game()
        {
            player1 = new Human("Player One");
            rules = new List<string>();
        }
        
        
        public void RunGame()
        {
            WelcomeScreen();
            DisplayTheRules();
            ChooseGameMod();
            player1.ChoosePlayerName();
            player2.ChoosePlayerName();
        }
        
        //Member Methods (CAN DO)

       
        //adds the rules to rules list
        public void AddTheRules()
        {
            rules.Add("\nRock crushes Scissor");
            rules.Add("Scissors cuts Paper");
            rules.Add("Paper covers Rock");
            rules.Add("Rock crushes Lizard");
            rules.Add("Lizard poisons Spock");
            rules.Add("Spock smashes Scissors");
            rules.Add("Scissors decapitates Lizard");
            rules.Add("Lizard eats Paper");
            rules.Add("Paper disproves Spock");
            rules.Add("Spock vaporizes Rock");
            
                        
        }

        // it displays the game rules
        public void DisplayTheRules()
        {
            AddTheRules();
            Console.WriteLine("Game rules:");
            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }
            Console.WriteLine("\nPress ENTER if you understand the rules and continue!");
            Console.ReadLine();
        }

        // welcome game information screen         
        public void WelcomeScreen()
        {
            Console.WriteLine("\nWelcome to ****----Rock Paper Scissors Lizard Spock----**** game!");
            Console.WriteLine();
        }

        // user can choose game mod
        public void ChooseGameMod()
        {
            Console.WriteLine("Choose your game mod here!");
            Console.WriteLine("Please press 1 and click ENTER! for Player vs Player\nPlease press 2 and click ENTER! for Player vs Computer");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                player2 = new Human("Player 2");
            }
            else if (userInput == "2")
            {
                player2 = new Computer("Mac");
            }
            else
            {
                while (userInput != "1" && userInput != "0")
                {
                    Console.WriteLine("Ooopppsss something wrong!!!\nPlease press 1 and click ENTER! for Player vs Player\nPlease press 2 and click ENTER! for Player vs Computer");
                    userInput = Console.ReadLine();
                    
                    if (userInput == "1")
                    {
                        player2 = new Human("Player 2");
                    }
                    else if (userInput == "2")
                    {
                        player2 = new Computer("Mac");
                    }
                }
            }
        }



    }
}
