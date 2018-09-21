using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer:Player
    {
        public HumanPlayer(string name)
        {
            score = 0;
            this.name = name;
            isComputer = false;
        }
        public override void ChooseGesture(List<Gesture> gestureOptions)
        {
            Console.Clear();
            ConsoleKeyInfo choice;
            while (true)
            {
                Console.WriteLine("{1}, please chose a gesture to throw (press a number 1 to {0}):{2}", gestureOptions.Count, name, Environment.NewLine);
                for(int i = 0; i < gestureOptions.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i+1, gestureOptions[i].Data);
                }
                choice = Console.ReadKey();
                Console.Clear();
                for(int i = 0; i < gestureOptions.Count; i++)
                {
                    if(i+1 == (int)Char.GetNumericValue(choice.KeyChar))
                    {
                        gesture = gestureOptions[i];
                        return;
                    }
                }
                
            }
            
            
        }

    }
}
