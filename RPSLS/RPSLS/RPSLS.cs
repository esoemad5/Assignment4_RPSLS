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
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scisors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }
    }
}
