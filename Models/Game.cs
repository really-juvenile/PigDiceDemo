
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceDemo.Models
{
    public class Game
    {
        private int diceRoll;
        private int totalScore = 0;
        private int turnCounter = 0;
        private bool turnOver;
        const int winningScore = 20; //avoid magic number
        private Random random;
        private string user_input;

        //public Game()
        //{
        //    diceRoll =0;
        //    totalScore = 0;
        //    turnCounter = 0;
        //    turnOver = true;
        //    random = new Random();
        //}




        public void Play()
        {
            while (true)
            {
                turnCounter++;
                turnOver = false;

                Console.WriteLine($"Turn {turnCounter} starts. Your total score is {totalScore}.");
                while (!turnOver)
                {
                    {
                        Console.WriteLine("enter 'r' to roll or 'h' to hold.");
                        user_input = (Console.ReadLine());

                        if (user_input == "r")
                        {

                            roll();

                        }
                        else if (user_input == "h")
                        {
                            Hold();

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please type 'r' or 'h'.");
                        }

                    }

                }
            }
        }

            private void roll()
            {

                Random random = new Random();
                diceRoll = random.Next(1, 7);
                Console.WriteLine($"You rolled a {diceRoll}");

                if (diceRoll == 1)
                {
                    totalScore = 0;
                    Console.WriteLine("You rolled a 1. Total score resets to 0.");
                    turnOver = true;
                }
                else
                {
                    totalScore += diceRoll;
                    Console.WriteLine($"Current total score = {totalScore}");
                }
                if (totalScore >= winningScore)
                {
                    Console.WriteLine($"Congratulations! You've reached a total score of {totalScore} \n" +
                        $"and won the game!, tthe turns taken is {turnCounter}");

                    return;
                }

            }

            private void Hold()
            {
                Console.WriteLine($"You decided to hold. Your total score is now {totalScore}.");
                if (totalScore >= winningScore)
                {
                    Console.WriteLine($"Congratulations! You've reached a total score of {totalScore} \n" +
                        $"and won the game!, tthe turns taken is {turnCounter}");

                    return;
                }
                turnOver = true;
            }

            //private void NewTurn()
            //{
            //    turn++;
            //    totalScore = 0;
            //    Console.WriteLine($"Starting turn {turn}");
            //}



        }
    }