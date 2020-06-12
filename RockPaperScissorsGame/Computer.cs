using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class Computer : Player // inheritance (IS A TYPE OF)
    {
        
        //Member Variables (HAS A)
        
        //Constructor (SPAWNER)
        public Computer(string name)
        {
            this.name = name;
            type = "computer";
        }
        //Member Methods (CAN DO)
        public override void ChoosePlayerName()
        {
            Console.WriteLine($"Great! Computer name is {name}");
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

            random = new Random();
            gesture = random.Next(1, 5).ToString();

            Console.WriteLine($"{name} picked {gesture}");
            return gesture;
        }
    }
}

