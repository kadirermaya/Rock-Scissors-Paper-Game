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
        public Random random;
        public string randomNumber;
        public string gesture;

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

        //// this method displays gestures
        //public void ChooseAGesture()
        //{


        //}

        // checks if player2 computer
        // picks random gesture if 
        public abstract string ChooseGesture();
        //{
        //    AddGestures();
        //    Console.WriteLine($"\n{name} choose your Gesture!");

        //    if (type == "human")
        //    {
        //        for (int i = 0; i < gestures.Count; i++)
        //        {
        //            Console.Write($"{i + 1}:{gestures[i]} ");
        //        }
        //        gesture = Console.ReadLine();
        //        return gesture;
        //    }


        //    else if (type == "computer")
        //    {
        //        for (int i = 0; i < gestures.Count; i++)
        //        {
        //            Console.Write($"{i + 1}:{gestures[i]} ");
        //        }

        //        random = new Random();
        //        gesture = random.Next(1, 5).ToString();

        //        Console.WriteLine($"{name} picked {gesture}");
        //        return gesture;
        //    }

        // return "";

    }
    
}
