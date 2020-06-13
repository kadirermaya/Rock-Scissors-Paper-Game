using System;
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
        public bool isWinnerFound = false;




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
            StartGame();
            CompareTheRound();
            CheckIfThereIsWinner();

        }

        //Member Methods (CAN DO)


        //adds the rules to rules list
        public void AddTheRules()
        {
            rules.Add("\n1.  Rock crushes Scissor");
            rules.Add("2.  Scissors cuts Paper");
            rules.Add("3.  Paper covers Rock");
            rules.Add("4.  Rock crushes Lizard");
            rules.Add("5.  Lizard poisons Spock");
            rules.Add("6.  Spock smashes Scissors");
            rules.Add("7.  Scissors decapitates Lizard");
            rules.Add("8.  Lizard eats Paper");
            rules.Add("9.  Paper disproves Spock");
            rules.Add("10. Spock vaporizes Rock");
        }

        // it displays the game rules
        public void DisplayTheRules()
        {
            AddTheRules();
            Console.WriteLine("******\\\\\\Game rules///****");
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
            Console.WriteLine("----------- Choose your game mod here! -----------");
            Console.WriteLine("\nPlease press 1 and click ENTER! for - Player vs Player - \nPlease press 2 and click ENTER! for - Player vs Computer - ");
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
                while (userInput != "1" && userInput != "2")
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
            PlayerOneGetsPoint();
            if (!isWinnerFound)
            { 
                PlayerTwoGetsPoint();
            }
            if (!isWinnerFound)
            {
                Tie();
            }
            
            isWinnerFound = false;
        }

        // chooses best of three
        public void CheckIfThereIsWinner()
        {
            while (player1Score != 2 && player2Score != 2)
            {
                StartGame();
                CompareTheRound();
                if (player1Score == 2 || player2Score == 2)
                {
                    if (player1Score == 2)
                    {
                        Console.WriteLine($"The winner is ********-----{player1.name}-----********");
                    }
                    else if (player2Score == 2)
                    {
                        Console.WriteLine($"The winner is ********-----{player2.name}-----********");
                    }

                }
            }
        }

        //this method starts the game
        public void StartGame()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
        }

        // checks who gets a point
        public void PlayerOneGetsPoint()
        {
            if (player1.gesture == "1" && player2.gesture == "3")
            {
                Console.WriteLine($"Rock crushes Scissors");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
            else if (player1.gesture == "3" && player2.gesture == "2")
            {
                Console.WriteLine($"Scissors cuts Paper");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;

            }
            else if (player1.gesture == "2" && player2.gesture == "1")
            {
                Console.WriteLine($"Paper covers Rock");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
            else if (player1.gesture == "1" && player2.gesture == "5")
            {
                Console.WriteLine($"Rock crushes Lizard");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }

            else if (player1.gesture == "5" && player2.gesture == "4")
            {
                Console.WriteLine($"Lizard poisons Spock");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;

            }
            else if (player1.gesture == "4" && player2.gesture == "3")
            {
                Console.WriteLine($"Spock smashes Scissors");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;

            }
            else if (player1.gesture == "3" && player2.gesture == "5")
            {
                Console.WriteLine($"Scissors decapitates Lizard");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
            else if (player1.gesture == "5" && player2.gesture == "3")
            {
                Console.WriteLine($"Lizard eats Paper");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
            else if (player1.gesture == "2" && player2.gesture == "4")
            {
                Console.WriteLine($"Paper disproves Spock");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
            else if (player1.gesture == "4" && player2.gesture == "1")
            {
                Console.WriteLine($"Spock vaporizes Rock");
                player1Score++;
                Console.WriteLine($"{player1.name} gets this round");
                Console.WriteLine($"{player1.name} score {player1Score} and {player2.name} score {player2Score}");
                isWinnerFound = true;
            }
        }
        public void PlayerTwoGetsPoint()
        {
            if (player2.gesture == "1" && player1.gesture == "3")
            {
                Console.WriteLine($"Rock crushes Scissors");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "3" && player1.gesture == "2")
            {
                Console.WriteLine($"Scissors cuts Paper");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "2" && player1.gesture == "1")
            {
                Console.WriteLine($"Paper covers Rock");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "1" && player1.gesture == "5")
            {
                Console.WriteLine($"Rock crushes Lizard");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "5" && player1.gesture == "4")
            {
                Console.WriteLine($"Lizard poisons Spock");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "4" && player1.gesture == "3")
            {
                Console.WriteLine($"Spock smashes Scissors");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "3" && player1.gesture == "5")
            {
                Console.WriteLine($"Scissors decapitates Lizard");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "5" && player1.gesture == "3")
            {
                Console.WriteLine($"Lizard eats Paper");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "2" && player1.gesture == "4")
            {
                Console.WriteLine($"Paper disproves Spock");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }
            else if (player2.gesture == "4" && player1.gesture == "1")
            {
                Console.WriteLine($"Spock vaporizes Rock");
                player2Score++;
                Console.WriteLine($"{player2.name} gets this round");
                Console.WriteLine($"{player2.name} score {player2Score} and {player1.name} score {player1Score}");
                isWinnerFound = true;
            }

        }
        public void Tie()
        {
            if (player1.gesture == "1" && player2.gesture == "1")
            {
                Console.WriteLine($"Rock and Rock! Tie");

            }
            else if (player1.gesture == "2" && player2.gesture == "2")
            {
                Console.WriteLine($"Scissors and Scissors! Tie");
            }
            else if (player1.gesture == "3" && player2.gesture == "3")
            {
                Console.WriteLine($"Paper and Paper! Tie");
            }
            else if (player1.gesture == "4" && player2.gesture == "4")
            {
                Console.WriteLine($"Soock and Spock! Tie");
            }
            else if (player1.gesture == "5" && player2.gesture == "5")
            {
                Console.WriteLine($"Lizard and Lizard! Tie");
            }

        }

      
    }
}
