using static MathGame.RyanW84.DifficultyEnum;
using static MathGame.RyanW84.GameLogic;
using static MathGame.RyanW84.MenuEnum;
using static MathGame.RyanW84.MenuSystem;

namespace MathGame.RyanW84;

internal class Program
{
    static void Main(string[] args)
    {
        MenuSystem.Intro();
        MenuSystem.GetName();
        MenuSystem.GetDifficulty();
        MenuSystem.GetOperator();
    }
}
