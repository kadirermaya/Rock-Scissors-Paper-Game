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
        public List<string> rules;
        

        //Constructor (SPAWNER)
        public Game()
        {
            player1 = new Player();
            rules = new List<string>();
        }
        //Member Methods (CAN DO)

       
        //adds the rules to rules list
        public void AddTheRules()
        {
            rules.Add("Rock crushes Scissor");
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

        public void DisplayTheRules()
        {
            AddTheRules();
            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
            }
        }





    }
}
