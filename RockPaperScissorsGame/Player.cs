using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public abstract class Player
    {
        //Member Variables (HAS A)
        public List<string> gestures;
        public string name;
        public string type;

        //Constructor (SPAWNER)

        public Player()
        {
            
        }
        
        //Member Methods (CAN DO)



        //adds gestures in a list
        public void AddGestures()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Spock");
            gestures.Add("Lizard");
        }

        // this is an abstract method
        public abstract void ChoosePlayerName();

        // this method displays gestures
        public void DisplayGesture()
        {
            AddGestures();
            Console.WriteLine($"{name} choose your Gesture!");
            
            for (int i = 0; i < gestures.Count; i++)
            {
            Console.Write($"{i + 1}:{gestures[i]} ");
            }
            Console.WriteLine();

        }
        
    }
}
