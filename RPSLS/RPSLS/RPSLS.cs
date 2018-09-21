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
        List<string> gestures;
        OneWayGraph<string> rulesGraph;


        public RPSLS()
        {
            makeGesturesList();
            createRulesGraph();
        }
        private void createRulesGraph()
        {
            rulesGraph = new OneWayGraph<string>();


            
        }
        private void makeGesturesList()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

    }
}
