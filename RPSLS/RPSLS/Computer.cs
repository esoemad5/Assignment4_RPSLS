using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{

    class Computer:Player
    {
        public Computer()
        {
            name = "Joshua";
            score = 0;
            isComputer = true;
        }
        public override void ChooseGesture(List<Gesture> gestureOptions)
        {
            Random random = new Random();
            int i = random.Next(0, 5);
            gesture = gestureOptions[i];
        }

    }
}
