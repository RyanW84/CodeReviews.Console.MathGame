using static MathGame.RyanW84.MenuEnum;
using static MathGame.RyanW84.MenuSystem;

namespace MathGame.RyanW84;

public class ScoreKeeper
{
    public static List<int> scoreList = new List<int>();
    public static int totalScore;

    public static void TotalScore(Operator menuOperator)
    {
        string divider = "\t*********************************";

        Console.Clear();
        Console.WriteLine(divider);
        Console.WriteLine($"\t\t      {menuOperator}");
        Console.WriteLine(divider);

        totalScore = scoreList.Sum();

        Console.WriteLine();
        Console.WriteLine($"The total score is {totalScore}");

        Console.WriteLine("\nPress any key to return to the Menu");
        Console.ReadLine();
        Console.Clear();
        GetOperator();
    }
}
