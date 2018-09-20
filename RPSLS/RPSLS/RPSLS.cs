using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RPSLS
    {
        List<Player> players;
        List<Gesture> gestures;

        public Game()
        {
            gestures.Add(new Rock);
            gestures.Add(new Paper);
            gestures.Add(new Scissors);
            gestures.Add(new Lizard);
            gestures.Add(new Spock);
        }
    }
}
