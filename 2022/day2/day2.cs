using System;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"input.txt");
            
            Console.WriteLine(CalculatePartOneScore(input));
            Console.WriteLine(CalculatePartTwoScore(input));
        }

        static int CalculatePartOneScore(string[] input){
            int totalScore = 0;
            foreach(string line in input){
                string[] splits = line.Split(' ');
                Hand opponent = DecodeStringHand(splits[0]);
                Hand player = DecodeStringHand(splits[1]);
                totalScore += CalculateRoundScore(opponent, player);
            }
            return totalScore;
        }

        static int CalculatePartTwoScore(string[] input){
            int totalScore = 0;
            foreach(string line in input){
                string[] splits = line.Split(' ');
                Hand opponent = DecodeStringHand(splits[0]);
                Hand player = DecideHandFromStrategy(splits[1], opponent);
                totalScore += CalculateRoundScore(opponent, player);
            }
            return totalScore;
        }

        static Hand DecodeStringHand(string hand){
            if (hand == "A" || hand == "X"){
                return Hand.Rock;
            } else if (hand == "B" || hand == "Y"){
                return Hand.Paper;
            } else if (hand == "C" || hand == "Z"){
                return Hand.Scissor;
            } else {
                throw new Exception("Hand could not be decoded");
            }

        }

        static Hand DecideHandFromStrategy(string strategy, Hand opponent){
            if (strategy == "X"){
                if (opponent == Hand.Rock){
                    return Hand.Scissor;
                } else if (opponent == Hand.Paper){
                    return Hand.Rock;
                } else {
                    return Hand.Paper;
                }
            } else if (strategy == "Y"){
                return opponent;
            } else if (strategy == "Z"){
                if (opponent == Hand.Rock){
                    return Hand.Paper;
                } else if (opponent == Hand.Paper){
                    return Hand.Scissor;
                } else {
                    return Hand.Rock;
                }
            } else {
                throw new Exception("Strategy could not be decoded");
            }
        }

        enum Hand {
            Rock,
            Paper,
            Scissor
        }

        static int CalculateRoundScore(Hand opponent, Hand player){
            int scoreForSelection = 0;
            switch (player){
                case Hand.Rock:
                    scoreForSelection = 1;
                    break;
                case Hand.Paper:
                    scoreForSelection = 2;
                    break;
                case Hand.Scissor:
                    scoreForSelection = 3;
                    break;
            }
            return scoreForSelection + CalculateWinner(opponent, player);
        }

        static int CalculateWinner(Hand opponent, Hand player){
            if (opponent == player){
                return 3;
            } else if ((player == Hand.Rock && opponent == Hand.Scissor) || 
                    (player == Hand.Paper && opponent == Hand.Rock) ||
                    (player == Hand.Scissor && opponent == Hand.Paper)){
                return 6;
            } else {
                return 0;
            }
        }
    }
}