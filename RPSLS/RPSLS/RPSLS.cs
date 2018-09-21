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
        List<Node> gestures;
        OneWayGraph<string> rulesGraph;


        public RPSLS()
        {
            createRulesGraph();
        }
        private void createRulesGraph()
        {
            Node rock = new Node("Rock");
            Node paper = new Node("Paper");
            Node scissors = new Node("Scissors");
            Node lizard = new Node("Lizard");
            Node spock = new Node("Spock");

            gestures.Add(rock);
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);

            rock.AddToListOfThingsItBeats(scissors);
            rock.AddToListOfThingsItBeats(lizard);
            paper.AddToListOfThingsItBeats(spock);
            paper.AddToListOfThingsItBeats(rock);
            scissors.AddToListOfThingsItBeats(lizard);
            scissors.AddToListOfThingsItBeats(paper);
            lizard.AddToListOfThingsItBeats(spock);
            lizard.AddToListOfThingsItBeats(paper);
            spock.AddToListOfThingsItBeats(rock);
            spock.AddToListOfThingsItBeats(scissors);
        }


    }
}
