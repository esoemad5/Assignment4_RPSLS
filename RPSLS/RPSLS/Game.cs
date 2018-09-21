using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        
namespace RPSLS
{
    class Game
    {
        private List<Player> players;
        private List<Gesture> gestures;
        private Player player1;
        private Player player2;

        public Game()
        {
            gestures = new List<Gesture>();
            players = new List<Player>();
            createRulesGraph();
            NewGame();
        }
        private void createRulesGraph()
        {
            // Create Gestures
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");
            
            // Define rules for Gestures
            gestures.Add(rock);
            rock.AddToListOfThingsItBeats(scissors);
            rock.AddToListOfThingsItBeats(lizard);

            gestures.Add(paper);
            paper.AddToListOfThingsItBeats(spock);
            paper.AddToListOfThingsItBeats(rock);

            gestures.Add(scissors);
            scissors.AddToListOfThingsItBeats(lizard);
            scissors.AddToListOfThingsItBeats(paper);

            gestures.Add(lizard);
            lizard.AddToListOfThingsItBeats(spock);
            lizard.AddToListOfThingsItBeats(paper);

            gestures.Add(spock);
            spock.AddToListOfThingsItBeats(rock);
            spock.AddToListOfThingsItBeats(scissors);
        }

        private void NewGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! You don't even have to have a friend to play with. In the likely case that you have no friends, you can play against me!");
            Console.WriteLine("Games are best 2 out of 3.");
            

            ConsoleKeyInfo choice;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Please enter number of players (press 1 or 2):");
                choice = Console.ReadKey();
                Console.WriteLine("");

                if (choice.KeyChar == '1')
                {
                    Console.WriteLine("Player 1: Please enter your name:");
                    player1 = new HumanPlayer();
                    player2 = new ComputerPlayer();
                    validInput = true;
                }
                if(choice.KeyChar == '2')
                {
                    player1 = new HumanPlayer();
                    player2 = new ComputerPlayer();
                    validInput = true;

                }
            }

            while(player1.score < 2 || player2.score < 2)
            {
                break;
            }

            Console.WriteLine("Thank you for playing!");
        }

        /* Game flow:
         * players choose gestures
         * see who wins round
         * increment points
         * check score
         * declare winner (maybe)
         * play again?
         */
    }
}
