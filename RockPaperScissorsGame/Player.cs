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

        //Constructor (SPAWNER)

        public Player()
        {
            
        }
        
        //Member Methods (CAN DO)



        //adds gestures in a list
        public void AddGestures()
        {
            gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("spock");
            gestures.Add("lizard");
        }

        public abstract void ChoosePlayerName();
        
    }
}
