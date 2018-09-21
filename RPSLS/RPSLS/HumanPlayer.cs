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
            bool validInput = false;
            ConsoleKeyInfo choice;
            while (!validInput)
            {
                Console.WriteLine("Please chose a gesture to throw (press a number 1 to 5):{0}1. Rock{0}2. Paper{0}3. Scissors{0}4. Lizard{0}5. Spock", Environment.NewLine);
                choice = Console.ReadKey();

                if(choice.KeyChar == '1' || choice.KeyChar != '2' || choice.KeyChar != '3' || choice.KeyChar != '4' || choice.KeyChar != '5')
                {
                    return gestureOptions()
                }
            }
            
            
        }
    }
}
