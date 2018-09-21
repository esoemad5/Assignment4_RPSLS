using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        protected string name;
        public int score;
        Gesture choice;

        public abstract void ChooseGesture();
    }
}
