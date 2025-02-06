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
        string escapeToMenu = "";
        char arithmeticOperator = ' ';
        int x = 0;
        int y = 0;
        int sumInput = 0;

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
                sum = x - y;
                break;
            case MenuEnum.Operator.Multiplication:
                arithmeticOperator = '*';
                sum = x * y;
                break;
            case MenuEnum.Operator.Division:
                arithmeticOperator = '/';
                do // only select random numbers that generate a whole number result on division
                {
                    x = random.Next(0, MenuSystem.xMaxValue);
                    y = random.Next(0, MenuSystem.yMaxValue);
                    if (y > x)
                    {
                        (x, y) = (y, x);
                    }
                    if (y == 0 || x == 0)
                    {
                        x = random.Next(0, MenuSystem.xMaxValue);
                        y = random.Next(0, MenuSystem.yMaxValue);
                    }
                } while (x % y == 0);
                sum = x / y;
                break;

                public static void DoSum()
    {
        Console.Clear();
        Console.WriteLine(divider);
        Console.WriteLine($"\t{menuOperator} Challenge!");
        Console.WriteLine(divider);
        Console.WriteLine($"Solve this sum: {Arithmetic.x} {arithmeticOperator} {y}");
        Gamelogic.Arithmetic.sumInput = int.Parse(Console.ReadLine());
        if (sumInput == sum)
        {
            Console.WriteLine($"That's correct {x} {arithmeticOperator} {y}  is {sum}");
        }
        else
        {
            Console.WriteLine("I'm sorry that was incorrect, let's try a new question.");
        }
    }
}
}

/*operator.Trim().ToUpper() == "ADDITION")*/
//{
//    do
//    {
//                Console.Clear();
//                Console.WriteLine(divider);
//                Console.WriteLine($"\t\t{menuoperator} Challenge");
//                Console.WriteLine(divider);

//                x = random.Next(0, MathGame.MenuSystem.xMaxValue);
//                y = random.Next(0, MathGame.MenuSystem.yMaxValue);

//                Console.WriteLine($"\nSolve this Sum: {x} + {y} = ");
//                Console.Write("\nPlease enter the answer: ");
//                sum = int.Parse(Console.ReadLine());

//                if (sum != x + y)
//                {
//                    Console.WriteLine("\nWrong answer, new question chosen");
//                    MathGame.ScoreKeeper.scoreList.Add(-1);

//                    Console.Write(
//                        "\nIf you would prefer to exit to the menu, please enter M now: "
//                    );
//                    escapeToMenu = Console.ReadLine().Trim().ToUpper();

//                    if (escapeToMenu == "M")
//                    {
//                        MathGame.MenuSystem.Menu();
//                    }
//                }
//                else
//{
//    Console.WriteLine($"\nCongratulations {sum} is correct!");
//    correctAnswer = true;
//    MathGame.ScoreKeeper.scoreList.Add(1);
//}
//            } while (correctAnswer == false) ;
//        }
//        else if (menuoperator.Trim().ToUpper() == "SUBTRACTION")
//{
//    do
//    {
//        Console.Clear();
//        Console.WriteLine(divider);
//        Console.WriteLine($"\t\t{menuoperator} Challenge");
//        Console.WriteLine(divider);

//        x = random.Next(0, MathGame.MenuSystem.xMaxValue);
//        y = random.Next(0, MathGame.MenuSystem.yMaxValue);

//        Console.WriteLine($"\nSolve this Sum: {x} - {y} = ");
//        Console.Write("\nPlease enter the answer: ");
//        sum = int.Parse(Console.ReadLine());

//        if (sum != x - y)
//        {
//            Console.WriteLine("\nWrong answer, new question chosen");
//            MathGame.ScoreKeeper.scoreList.Add(-1);

//            Console.Write(
//                "\nIf you would prefer to exit to the menu, please enter M now: "
//            );
//            escapeToMenu = Console.ReadLine().Trim().ToUpper();

//            if (escapeToMenu == "M")
//            {
//                MathGame.MenuSystem.Menu();
//            }
//        }
//        else
//        {
//            Console.WriteLine($"\nCongratulations {sum} is correct!");
//            correctAnswer = true;
//            MathGame.ScoreKeeper.scoreList.Add(1);
//        }
//    } while (correctAnswer == false);
//}
//else if (menuoperator.Trim().ToUpper() == "MULTIPLICATION")
//{
//    do
//    {
//        Console.Clear();
//        Console.WriteLine(divider);
//        Console.WriteLine($"\t\t{menuoperator} Challenge");
//        Console.WriteLine(divider);

//        x = random.Next(0, MathGame.MenuSystem.xMaxValue);
//        y = random.Next(0, MathGame.MenuSystem.yMaxValue);

//        Console.WriteLine($"\nSolve this Sum: {x} * {y} = ");
//        Console.Write("\nPlease enter the answer: ");
//        sum = int.Parse(Console.ReadLine());

//        if (sum != x * y)
//        {
//            Console.WriteLine("\nWrong answer, new question chosen");
//            MathGame.ScoreKeeper.scoreList.Add(-1);

//            Console.Write(
//                "\nIf you would prefer to exit to the menu, please enter M now: "
//            );
//            escapeToMenu = Console.ReadLine().Trim().ToUpper();

//            if (escapeToMenu == "M")
//            {
//                MathGame.MenuSystem.Menu();
//            }
//        }
//        else
//        {
//            Console.WriteLine($"\nCongratulations {sum} is correct!");
//            correctAnswer = true;
//            MathGame.ScoreKeeper.scoreList.Add(1);
//        }
//    } while (correctAnswer == false);
//}
//else if (menuoperator.Trim().ToUpper() == "DIVISION")
//{
//    do
//    {
//        Console.Clear();
//        Console.WriteLine(divider);
//        Console.WriteLine($"\t\t{menuoperator} Challenge");
//        Console.WriteLine(divider);

//        do // only select random numbers that generate a whole number result on division
//        {
//            x = random.Next(0, MathGame.MenuSystem.xMaxValue);
//            y = random.Next(0, MathGame.MenuSystem.yMaxValue);
//            if (y > x)
//            {
//                (x, y) = (y, x);
//            }
//            if (y == 0 || x == 0)
//            {
//                x = random.Next(0, MathGame.MenuSystem.xMaxValue);
//                y = random.Next(0, MathGame.MenuSystem.yMaxValue);
//            }
//        } while (x % y == 0);

//        Console.WriteLine($"\nSolve this Sum: {x} / {y} = ");
//        Console.Write("\nPlease enter the answer: ");
//        sum = int.Parse(Console.ReadLine());

//        if (sum != x / y)
//        {
//            Console.WriteLine("\nWrong answer, new question chosen");
//            MathGame.ScoreKeeper.scoreList.Add(-1);

//            Console.Write(
//                "\nIf you would prefer to exit to the menu, please enter M now: "
//            );
//            escapeToMenu = Console.ReadLine().Trim().ToUpper();

//            if (escapeToMenu == "M")
//            {
//                MathGame.MenuSystem.Menu();
//            }
//        }
//        else
//        {
//            Console.WriteLine($"\nCongratulations {sum} is correct!");
//            correctAnswer = true;
//            MathGame.ScoreKeeper.scoreList.Add(1);
//        }
//    } while (correctAnswer == false);
//}
//else if (menuoperator.Trim().ToUpper() == "RANDOM")
//{
//    Console.Clear();
//    Console.WriteLine(divider);
//    Console.WriteLine($"\t\t{menuoperator} Challenge");
//    Console.WriteLine(divider);

//    Random randomGame = new Random();
//    string[] gameChoice = { "Addition", "Subtraction", "Multiplication", "Division" };
//    int gameChoiceArrayPointer = randomGame.Next(0, gameChoice.Length);
//    menuoperator = gameChoice[gameChoiceArrayPointer];
//    MathGame.GameLogic.Arithmetic(menuoperator);
//}

//                Console.WriteLine("\nPress any key to return to the Menu");
//                Console.ReadLine();
//                Console.Clear();
//                MathGame.MenuSystem.BeginGame(MenuSystem.name, MenuSystem.difficultyInput);
//            }
//}
