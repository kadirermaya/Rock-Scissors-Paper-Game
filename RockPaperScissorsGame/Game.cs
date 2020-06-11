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

        public List<string> gestures;

        //Constructor (SPAWNER)
        public Game()
        {
            
        }
        //Member Methods (CAN DO)

        public void AddGestures()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("spock");
            gestures.Add("lizard");
        }

        public void DisplayGestures()
        {
            Console.WriteLine("Please choose a gesture!");
            Console.WriteLine($"0: {gestures[0]} 1: {gestures[1]} 2: {gestures[2]} 3: {gestures[3]} 4: {gestures[4]}");
            
        }


    }
}
