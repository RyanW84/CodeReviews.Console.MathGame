using static MathGame.RyanW84.DifficultyEnum;
using static MathGame.RyanW84.MenuEnum;
using static MathGame.RyanW84.MenuSystem;

namespace MathGame.RyanW84;

public class GameLogic()
{
    public static void Arithmetic(Difficulty difficulty, Operator menuOperator)
    {
        Random random = new Random();
        int sum = 0;
        bool correctAnswer = false;
        bool exitGame = false;
        string escapeToMenu = "";
        char arithmeticOperator = ' ';
        int x = 0;
        int y = 0;
        int sumInput = 0;
        Random randomEnum = new Random();

        switch (difficulty)
        {
            case Difficulty.Easy:
                xMaxValue = 10;
                yMaxValue = 10;
                difficultyChosen = true;
                break;
            case Difficulty.Medium:
                xMaxValue = 100;
                yMaxValue = 100;
                difficultyChosen = true;
                break;
            case Difficulty.Hard:
                xMaxValue = 1000;
                yMaxValue = 1000;
                difficultyChosen = true;
                break;
            default:
                Console.WriteLine("Invalid difficulty selected");
                showMenu = true;
                difficultyChosen = false;
                GetDifficulty();
                break;
        }

        switch (menuOperator)
        {
            case MenuEnum.Operator.Addition:
                arithmeticOperator = '+';
                x = random.Next(0, xMaxValue);
                y = random.Next(0, yMaxValue);
                sum = x + y;
                break;
            case MenuEnum.Operator.Subtraction:
                arithmeticOperator = '-';
                x = random.Next(0, xMaxValue);
                y = random.Next(0, yMaxValue);
                sum = x - y;
                break;
            case MenuEnum.Operator.Multiplication:
                arithmeticOperator = '*';
                x = random.Next(0, xMaxValue);
                y = random.Next(0, yMaxValue);
                sum = x * y;
                break;
            case MenuEnum.Operator.Division:
                bool zeroCheck = false;
                arithmeticOperator = '/';

                while (!zeroCheck) // only select random numbers that generate a whole number result on division
                {
                    x = random.Next(0, MenuSystem.xMaxValue);
                    y = random.Next(0, MenuSystem.yMaxValue);
                    if (y == 0 || x == 0)
                    {
                        x = random.Next(0, MenuSystem.xMaxValue);
                        y = random.Next(0, MenuSystem.yMaxValue);
                    }
                    if (y > x)
                    {
                        (x, y) = (y, x);
                    }

                    zeroCheck = true;
                }
                sum = x / y;
                break;
            case MenuEnum.Operator.Random:
                Console.Clear();
                Console.WriteLine("Randomly choosing a Maths challenge"); // working on random selection
                int randomChooser = randomEnum.Next(1, 4);
                menuOperator = (Operator)randomChooser;
                exitGame = true;
                Arithmetic(difficulty, menuOperator);
                break;
            case MenuEnum.Operator.Score:
                ScoreKeeper.TotalScore(menuOperator);
                correctAnswer = true;
                showMenu = true;
                break;
            case MenuEnum.Operator.Exit:
                Console.Clear();
                Console.WriteLine("Thank you for playing");
                exitGame = true;
                break;
            default:
                Console.WriteLine("Please enter a valid input");
                showMenu = true;
                GetOperator();
                break;
        }
        while (exitGame == false && correctAnswer == false)
        {
            Console.Clear();
            Console.WriteLine(divider);
            Console.WriteLine($"\t{menuOperator} Challenge!");
            Console.WriteLine(divider);
            Console.WriteLine($"Solve this sum: {x} {arithmeticOperator} {y}");
            sumInput = int.Parse(Console.ReadLine());
            if (sumInput != sum)
            {
                Console.WriteLine("\nWrong answer, new question chosen");
                MathGame.RyanW84.ScoreKeeper.scoreList.Add(-1);
                correctAnswer = false;

                Console.Write("\nIf you would prefer to exit to the menu, please enter M now: ");
                escapeToMenu = Console.ReadLine().Trim().ToUpper();

                if (escapeToMenu == "M")
                {
                    correctAnswer = true;
                    showMenu = true;
                    MathGame.RyanW84.MenuSystem.GetOperator();
                }
            }
            else
            {
                Console.WriteLine($"\nCongratulations {sum} is correct!");
                correctAnswer = true;
                MathGame.RyanW84.ScoreKeeper.scoreList.Add(1);
                showMenu = true;
                MathGame.RyanW84.MenuSystem.GetOperator(); // figure out how to exit after menuOperator
            }
        }
    }
}
