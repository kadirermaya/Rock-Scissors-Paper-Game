﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public string gesture;
        public Random randomNumber;
        public int player1Score;
        public int player2Score;




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
            Console.WriteLine($"Let's begin the game!");
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareTheRound();
            


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
                player2 = new Computer("AI");
            }
            else
            {
                while (userInput != "1" &&  userInput != "2")
                {
                    Console.WriteLine("Ooopppsss something wrong!!!\nPlease press 1 and click ENTER! for Player vs Player\nPlease press 2 and click ENTER! for Player vs Computer");
                    userInput = Console.ReadLine();
                    
                    if (userInput == "1")
                    {
                        player2 = new Human("Player 2");
                    }
                    else if (userInput == "2")
                    {
                        player2 = new Computer("AI");
                    }
                   
                }
            }
        }
        // this method compares the round
        public void CompareTheRound()
        {
            if (player1.gesture == "1" && player2.gesture == "3")
            {
                Console.WriteLine($"Rock crushes Scissors");
                player1Score++;
            }
            else if (player1.gesture == "3" && player2.gesture == "2")
            {
                Console.WriteLine($"Scissors cuts Paper");
                player1Score++;
            }
            else if (player1.gesture == "2" && player2.gesture == "1")
            {
                Console.WriteLine($"Paper covers Rock");
                player1Score++;
            }
            else if (player1.gesture == "1" && player2.gesture == "5")
            {
                Console.WriteLine($"Rock crushes Lizard");
                player1Score++;
            }
            else if (player1.gesture == "5" && player2.gesture == "4")
            {
                Console.WriteLine($"Lizard poisons Spock");
                player1Score++;
            }
            else if (player1.gesture == "4" && player2.gesture == "3")
            {
                Console.WriteLine($"Spock smashes Scissors");
                player1Score++;
            }
            else if (player1.gesture == "3" && player2.gesture == "5")
            {
                Console.WriteLine($"Scissors decapitates Lizard");
                player1Score++;
            }
            else if (player1.gesture == "5" && player2.gesture == "3")
            {
                Console.WriteLine($"Lizard eats Paper");
                player1Score++;
            }
            else if (player1.gesture == "2" && player2.gesture == "4")
            {
                Console.WriteLine($"Paper disproves Spock");
                player1Score++;
            }
            else if (player1.gesture == "4" && player2.gesture == "1")
            {
                Console.WriteLine($"Spock vaporizes Rock");
                player1Score++;
            }
            else if (player1.gesture == "1" && player2.gesture == "1")
            {
                Console.WriteLine($"Tie");
            }
            else if (player1.gesture == "2" && player2.gesture == "2")
            {
                Console.WriteLine($"Tie");
            }
            else if (player1.gesture == "3" && player2.gesture == "3")
            {
                Console.WriteLine($"Tie");
            }
            else if (player1.gesture == "4" && player2.gesture == "4")
            {
                Console.WriteLine($"Tie");
            }
            else if (player1.gesture == "5" && player2.gesture == "5")
            {
                Console.WriteLine($"Tie");
            }
            else
            {
                player2Score++;
            }


        }






    }
}
