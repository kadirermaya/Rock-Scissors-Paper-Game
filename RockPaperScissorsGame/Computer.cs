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
        }
        //Member Methods (CAN DO)
        public override void ChoosePlayerName()
        {
            Console.WriteLine($"Great! Computer name is {name}");
           
        }
    }
}

