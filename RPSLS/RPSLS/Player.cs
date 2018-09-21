using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public int score;
        public Gesture gesture;

        public abstract void ChooseGesture(List<Gesture> gestureOptions);
    }
}
