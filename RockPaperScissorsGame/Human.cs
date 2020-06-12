using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class Human : Player  // inheritance (IS A TYPE OF)
    {
        //Member Variables (HAS A)
        
        public Human(string name)
        {
            this.name = name;
            type = "human";
        }
        //Constructor (SPAWNER)
        //Member Methods (CAN DO)
        public override void ChoosePlayerName()
        {
            Console.WriteLine($"\nGreat! Lets pick a name for {name}");
            Console.WriteLine($"Type your player name and click ENTER!");
            name = Console.ReadLine();
            Console.WriteLine($"You succesfuly changed it. Your player name is {name} now!");
            Console.WriteLine();
        }

        public override string ChooseGesture()
        {
            AddGestures();
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.Write($"{i + 1}:{gestures[i]} ");
                }
            Console.WriteLine($"\n{name} choose your Gesture!");
                gesture = Console.ReadLine();
                return gesture;

            
            
        }
}
}
