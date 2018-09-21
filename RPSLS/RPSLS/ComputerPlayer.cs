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
        public override void ChooseGesture()
        {
            throw new NotImplementedException();
        }
    }
}
