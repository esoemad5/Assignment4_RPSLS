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
        List<Node<string>> gestures;
        OneWayGraph<string> rulesGraph;


        public RPSLS()
        {
            createRulesGraph();
        }
        private void createRulesGraph()
        {
            Node<string> rock = new Node<string>("Rock");
            Node<string> paper = new Node<string>("Paper");
            Node<string> scissors = new Node<string>("Scissors");
            Node<string> lizard = new Node<string>("Lizard");
            Node<string> spock = new Node<string>("Spock");

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
