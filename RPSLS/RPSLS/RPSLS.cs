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
            Node<string> rock = new Node<string>("Rock");
            Node<string> paper = new Node<string>("Paper");
            Node<string> scissors = new Node<string>("Scissors");
            Node<string> lizard = new Node<string>("Lizard");
            Node<string> spock = new Node<string>("Spock");
            rulesGraph = new OneWayGraph<string>(rock);
            rulesGraph.addToGraph(rock, paper);
            rulesGraph.addToGraph(rock, scissors);
            scissors.addToNext(paper);
            rulesGraph.addToGraph(paper, spock);
            spock.addToNext(rock);
            spock.addToNext(scissors);
            rulesGraph.addToGraph( );



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
