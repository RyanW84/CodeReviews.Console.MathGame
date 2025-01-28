﻿namespace MathGame
{
    public class ScoreKeeper
    {
        public static List<int> scoreList = new List<int>();
        public static int totalScore;

        internal static void TotalScore(string optionChosen)
        {
            string divider = "\t*********************************";

            Console.Clear();
            Console.WriteLine(divider);
            Console.WriteLine($"\t\t{optionChosen}");
            Console.WriteLine(divider);

            totalScore = scoreList.Sum();

            Console.WriteLine();
            Console.WriteLine($"The total score is {totalScore}");

            Console.WriteLine("\nPress any key to return to the Menu");
            Console.ReadLine();
            Console.Clear();
            MathGame.MenuSystem.Menu();
        }
    }
}
