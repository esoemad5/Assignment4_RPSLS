using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer:Player
    {
        public ComputerPlayer()
        {
            name = "Joshua";
            score = 0;
        }
        public override void ChooseGesture(List<Gesture> gestureOptions)
        {
            Random random = new Random();
            int i = random.Next(0, 5);
            gesture = gestureOptions[i];
        }
    }
}
