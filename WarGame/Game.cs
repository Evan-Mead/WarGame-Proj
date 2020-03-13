using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;
        int minParameter = 1;
        int maxParemeter = 6;
        string playerOne = "Player One";
        string playerTwo = "Player Two";
        int playerOneRoll;
        int playerTwoRoll;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        //Don't change anything above this ^^^^^^^^^^^^

        //Member Methods - All your methods go below here!
        public int RandomDiceRoll(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string UpdateScore()
        {
            string result = playerOne + " " + playerOneScore + " " + playerTwo + " " + playerTwoScore;
            return result;
        }

        public void RoundWinner()
        {
            if (playerOneRoll > playerTwoRoll)
            {
                Console.WriteLine("Player One wins the round.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player Two wins the round.");
                Console.ReadLine();
            }
            else if (playerOneRoll == playerTwoRoll)
            {
                Console.WriteLine("Round Tie.");
                Console.ReadLine();
            }
        }

        public void GameWinner()
        {
            if (playerOneScore >= playerTwoScore)
            {
                Console.WriteLine("Player One wins the game!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player Two wins the game!");
                Console.ReadLine();
            }
        }

        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
       public void RunGame()
        {
            Console.WriteLine("Welcome to the game of war!");
            Console.WriteLine(UpdateScore());
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                Console.WriteLine(playerOne + "roll");
                Console.ReadLine();

                playerOneRoll = RandomDiceRoll(minParameter, maxParemeter);
                Console.WriteLine("rolled a: " + playerOneRoll);

                Console.WriteLine(playerTwo + "roll");
                Console.ReadLine();

                playerTwoRoll = RandomDiceRoll(minParameter, maxParemeter);
                Console.WriteLine("rolled a: " + playerTwoRoll);

                RoundWinner();

                Console.WriteLine(UpdateScore());

                GameWinner();
            }
        }
    }
}