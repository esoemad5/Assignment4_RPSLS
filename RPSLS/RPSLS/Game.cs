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
        private int roundsNeededToWin;

        public Game(int roundsNeededToWin)
        {
            gestures = new List<Gesture>();
            players = new List<Player>();
            createRulesGraph();
            this.roundsNeededToWin = roundsNeededToWin;
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
            Console.WriteLine("Games are best {0} out of {1}.", roundsNeededToWin, 2*roundsNeededToWin-1);

            GetPlayers();

            while(player1.score < roundsNeededToWin || player2.score < roundsNeededToWin)
            {
                player1.ChooseGesture(gestures);
                player2.ChooseGesture(gestures);
                if (player1.gesture.Beats(player2.gesture)) ;
                break;
            }

            Console.WriteLine("Thank you for playing!");
        }
        private void GetPlayers()
        {
            string choice;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Please enter number of players (enter 1 or 2):");
                choice = Console.ReadLine();
                //Console.WriteLine("");

                if (choice == "1")
                {
                    Console.WriteLine("Player 1: Please enter your name:");
                    player1 = new HumanPlayer(Console.ReadLine());
                    player1.ChooseGesture(gestures);
                    player2 = new ComputerPlayer();
                    validInput = true;
                }
                if (choice == "2")
                {
                    Console.WriteLine("Player 1: Please enter your name:");
                    string player1Name = Console.ReadLine();
                    player1 = new HumanPlayer(player1Name);
                    Console.WriteLine("Player 2: Please enter your name:");
                    string player2Name = Console.ReadLine();
                    while(player1Name == player2Name)
                    {
                        Console.WriteLine("Player 2 must have a different name than Player 1.{0}Please enter a new name.", Environment.NewLine);
                        player2Name = Console.ReadLine();
                    }
                    player2 = new HumanPlayer(player2Name);
                    validInput = true;

                }
            }
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
