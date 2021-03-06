﻿using System;
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
            StartNewGame();
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
        private void StartNewGame()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! You don't even have to have a friend to play with. In the likely case that you have no friends, you can play against me!");
            Console.WriteLine("Games are best {0} out of {1}.", roundsNeededToWin, 2*roundsNeededToWin-1);

            CreatePlayers(GetNumberOfPlayers());
            Player winner = PlayGame();
            Console.Clear();
            Console.WriteLine("{0} wins!", winner.name);
            if (player2.isComputer)
            {
                Console.WriteLine("{0}What a strange game. How about a nice game of chess?{0}", Environment.NewLine);
            }
            else
            {
                Console.WriteLine("{0}Thank you for playing!{0}", Environment.NewLine);
            }
            
        }
        private int GetNumberOfPlayers()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Please enter number of players (enter 1 or 2):");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    return 1;
                }
                else if (choice == "2")
                {
                    return 2;
                }
                else{

                }

            }
        }
        private void CreatePlayers(int numberOfPlayers)
        {    
            if (numberOfPlayers == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Player 1: Please enter your name:");
                    player1 = new Human(Console.ReadLine());
                    player2 = new Computer();
                    Console.Clear();
                    if(player1.name == "Joshua")
                    {
                        Console.WriteLine("What a coincidence! My name is also Joshua! I'll be your opponent today since you don't have any friends.{1}{1}Please press any key to start playing!", player1.name, Environment.NewLine);
                        player2.name = "Computer";
                    }
                    else
                    {
                        Console.WriteLine("Hello {0}! My name is Joshua. I'll be your opponent today since you don't have any friends.{1}{1}Please press any key to start playing!", player1.name, Environment.NewLine);
                    }
                    Console.ReadKey();
                }
            if (numberOfPlayers == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Player 1: Please enter your name:");
                    string player1Name = Console.ReadLine();
                    player1 = new Human(player1Name);
                    Console.WriteLine("Player 2: Please enter your name:");
                    string player2Name = Console.ReadLine();
                    while(player1Name == player2Name)
                    {
                        Console.WriteLine("Player 2 must have a different name than Player 1.{0}Please enter a new name.", Environment.NewLine);
                        player2Name = Console.ReadLine();
                    }
                    player2 = new Human(player2Name);
                }
        }
        private Player PlayGame()
        {
            Player winner = null;
            while (player1.score < roundsNeededToWin && player2.score < roundsNeededToWin)
            {
                player1.ChooseGesture(gestures);
                player2.ChooseGesture(gestures);
                Console.WriteLine("{0} threw {1}! {2} threw {3}!", player1.name, player1.gesture.Data, player2.name, player2.gesture.Data);

                if (player1.gesture.Beats(player2.gesture))
                {
                    Console.WriteLine("{0} beats {1}! {2} wins this round!", player1.gesture.Data, player2.gesture.Data, player1.name);
                    winner = player1;
                    player1.score++;
                }
                else if (player2.gesture.Beats(player1.gesture))
                {
                    Console.WriteLine("{0} beats {1}! {2} wins this round!", player2.gesture.Data, player1.gesture.Data, player2.name);
                    winner = player2;
                    player2.score++;
                }
                else
                {
                    Console.WriteLine("Both players threw {0}! This round is a tie!", player1.gesture.Data);
                }
                Console.WriteLine("{4}{0}'s Score: {1}{4}{2}'s Score: {3}{4}{4}Press any key to continue.", player1.name, player1.score, player2.name, player2.score, Environment.NewLine);
                Console.ReadKey();
            }
            return winner;
        }

    }
}
