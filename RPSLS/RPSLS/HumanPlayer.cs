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
            throw new NotImplementedException();
        }
    }
}
