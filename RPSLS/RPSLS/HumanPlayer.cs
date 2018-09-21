using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer:Player
    {
        public HumanPlayer()
        {
            score = 0;
            name = Console.ReadLine();
        }
        public override Gesture ChooseGesture(List<Gesture> gestureOptions)
        {
            ConsoleKeyInfo choice;
            while (true)
            {
                Console.WriteLine("Please chose a gesture to throw (press a number 1 to {0}):", gestureOptions.Count);
                for(int i = 0; i < gestureOptions.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i+1, gestureOptions[i].Data);
                }
                choice = Console.ReadKey();
                for(int i = 0; i < gestureOptions.Count; i++)
                {
                    if(i+1 == Char.GetNumericValue(choice.KeyChar))
                    {
                        return gestureOptions[i];
                    }
                }
                
            }
            
            
        }

    }
}
