namespace MathGame;

internal class GameLogic
{
    internal static void Arithmetic(string optionChosen)
    {
        Random random = new Random();
        int x = 0;
        int y = 0;
        int sum = 0;
        bool correctAnswer = false;
        string divider = "\t*********************************";
        string escapeToMenu = "";

        if (optionChosen.Trim().ToUpper() == "ADDITION")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(divider);
                Console.WriteLine($"\t\t{optionChosen} Challenge");
                Console.WriteLine(divider);

                x = random.Next(0, MathGame.MenuSystem.xMaxValue);
                y = random.Next(0, MathGame.MenuSystem.yMaxValue);

                Console.WriteLine($"\nSolve this Sum: {x} + {y} = ");
                Console.Write("\nPlease enter the answer: ");
                sum = int.Parse(Console.ReadLine());

                if (sum != x + y)
                {
                    Console.WriteLine("\nWrong answer, new question chosen");
                    MathGame.ScoreKeeper.scoreList.Add(-1);

                    Console.Write(
                        "\nIf you would prefer to exit to the menu, please enter M now: "
                    );
                    escapeToMenu = Console.ReadLine().Trim().ToUpper();

                    if (escapeToMenu == "M")
                    {
                        MathGame.MenuSystem.Menu();
                    }
                }
                else
                {
                    Console.WriteLine($"\nCongratulations {sum} is correct!");
                    correctAnswer = true;
                    MathGame.ScoreKeeper.scoreList.Add(1);
                }
            } while (correctAnswer == false);
        }
        else if (optionChosen.Trim().ToUpper() == "SUBTRACTION")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(divider);
                Console.WriteLine($"\t\t{optionChosen} Challenge");
                Console.WriteLine(divider);

                x = random.Next(0, MathGame.MenuSystem.xMaxValue);
                y = random.Next(0, MathGame.MenuSystem.yMaxValue);

                Console.WriteLine($"\nSolve this Sum: {x} - {y} = ");
                Console.Write("\nPlease enter the answer: ");
                sum = int.Parse(Console.ReadLine());

                if (sum != x - y)
                {
                    Console.WriteLine("\nWrong answer, new question chosen");
                    MathGame.ScoreKeeper.scoreList.Add(-1);

                    Console.Write(
                        "\nIf you would prefer to exit to the menu, please enter M now: "
                    );
                    escapeToMenu = Console.ReadLine().Trim().ToUpper();

                    if (escapeToMenu == "M")
                    {
                        MathGame.MenuSystem.Menu();
                    }
                }
                else
                {
                    Console.WriteLine($"\nCongratulations {sum} is correct!");
                    correctAnswer = true;
                    MathGame.ScoreKeeper.scoreList.Add(1);
                }
            } while (correctAnswer == false);
        }
        else if (optionChosen.Trim().ToUpper() == "MULTIPLICATION")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(divider);
                Console.WriteLine($"\t\t{optionChosen} Challenge");
                Console.WriteLine(divider);

                x = random.Next(0, MathGame.MenuSystem.xMaxValue);
                y = random.Next(0, MathGame.MenuSystem.yMaxValue);

                Console.WriteLine($"\nSolve this Sum: {x} * {y} = ");
                Console.Write("\nPlease enter the answer: ");
                sum = int.Parse(Console.ReadLine());

                if (sum != x * y)
                {
                    Console.WriteLine("\nWrong answer, new question chosen");
                    MathGame.ScoreKeeper.scoreList.Add(-1);

                    Console.Write(
                        "\nIf you would prefer to exit to the menu, please enter M now: "
                    );
                    escapeToMenu = Console.ReadLine().Trim().ToUpper();

                    if (escapeToMenu == "M")
                    {
                        MathGame.MenuSystem.Menu();
                    }
                }
                else
                {
                    Console.WriteLine($"\nCongratulations {sum} is correct!");
                    correctAnswer = true;
                    MathGame.ScoreKeeper.scoreList.Add(1);
                }
            } while (correctAnswer == false);
        }
        else if (optionChosen.Trim().ToUpper() == "DIVISION")
        {
            do
            {
                Console.Clear();
                Console.WriteLine(divider);
                Console.WriteLine($"\t\t{optionChosen} Challenge");
                Console.WriteLine(divider);

                do // only select random numbers that generate a whole number result on division
                {
                    x = random.Next(0, MathGame.MenuSystem.xMaxValue);
                    y = random.Next(0, MathGame.MenuSystem.yMaxValue);
                } while (x % y == 0);

                Console.WriteLine($"\nSolve this Sum: {x} / {y} = ");
                Console.Write("\nPlease enter the answer: ");
                sum = int.Parse(Console.ReadLine());

                if (sum != x / y)
                {
                    Console.WriteLine("\nWrong answer, new question chosen");
                    MathGame.ScoreKeeper.scoreList.Add(-1);

                    Console.Write(
                        "\nIf you would prefer to exit to the menu, please enter M now: "
                    );
                    escapeToMenu = Console.ReadLine().Trim().ToUpper();

                    if (escapeToMenu == "M")
                    {
                        MathGame.MenuSystem.Menu();
                    }
                }
                else
                {
                    Console.WriteLine($"\nCongratulations {sum} is correct!");
                    correctAnswer = true;
                    MathGame.ScoreKeeper.scoreList.Add(1);
                }
            } while (correctAnswer == false);
        }
        else if (optionChosen.Trim().ToUpper() == "RANDOM")
        {
            Console.Clear();
            Console.WriteLine(divider);
            Console.WriteLine($"\t\t{optionChosen} Challenge");
            Console.WriteLine(divider);

            Random randomGame = new Random();
            string[] gameChoice = { "Addition", "Subtraction", "Multiplication", "Division" };
            int gameChoiceArrayPointer = randomGame.Next(0, gameChoice.Length);
            optionChosen = gameChoice[gameChoiceArrayPointer];
            MathGame.GameLogic.Arithmetic(optionChosen);
        }

        Console.WriteLine("\nPress any key to return to the Menu");
        Console.ReadLine();
        Console.Clear();
        MathGame.MenuSystem.Menu();
    }
}
