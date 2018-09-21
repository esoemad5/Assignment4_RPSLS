using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        List<Player> players;
        List<Gesture> gestures;


        public Game()
        {
            gestures = new List<Gesture>();
            players = new List<Player>();
            createRulesGraph();
            NewGame();
        }
        private void createRulesGraph()
        {
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");

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

        private void NewGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! You don't even have to have a friend to play with. In the likely case that you have none, you can play against me!");

            ConsoleKeyInfo choice;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter number of players:");
                choice = Console.ReadKey();
                if(choice.KeyChar == '1')
                {
                   // OnePlayerGame();
                    break;
                }
                if(choice.KeyChar == '2')
                {
                   // TwoPlayerGame();
                    break;

                }
            }
            Console.WriteLine("Thank you for playing!");
        }

    }
}
