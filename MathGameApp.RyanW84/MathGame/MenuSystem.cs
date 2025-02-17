namespace MathGame.RyanW84;

public static class DifficultyEnum
{
    public enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
    }
}

public static class MenuEnum
{
    public enum Operator
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        Random = 5,
        Score = 6,
        Exit = 7,
    }
}

internal class MenuSystem
{
    public static int xMaxValue;
    public static int yMaxValue;
    public static bool showMenu = true;
    public static string optionChosen = "";
    public static string divider = "***********************************";
    public static string name;
    public static bool difficultyChosen;
    public static string dateTimeStamp = DateTime.Now.ToString();
    public static DifficultyEnum.Difficulty difficulty;
    public static MenuEnum.Operator menuOperator;
    public static string difficultyInput;
    public static string menuInput;

    public static void Intro()
    {
        Console.WriteLine(dateTimeStamp);
        Console.WriteLine();
        Console.WriteLine(divider);
        Console.WriteLine("\tMaths Game + - * /");
        Console.WriteLine(divider);
        Console.WriteLine();
    }

    public static string GetName()
    {
        Console.WriteLine("Please tell  me your name: ");
        MenuSystem.name = Console.ReadLine().Trim();
        Console.WriteLine($"\nWelcome: {name}");
        return name;
    }

    public static void GetDifficulty()
    {
        while (difficultyChosen == false)
        {
            {
                Console.WriteLine("\nPlease choose your difficulty:\n");
                foreach (var value in Enum.GetValues(typeof(DifficultyEnum.Difficulty)))
                {
                    Console.WriteLine($"{value} {(int)value}");
                }

                difficultyInput = Console.ReadLine();

                if (
                    Enum.TryParse<DifficultyEnum.Difficulty>(
                        difficultyInput,
                        out DifficultyEnum.Difficulty difficultyParsed
                    )
                )
                {
                    difficultyChosen = true;
                    difficulty = difficultyParsed;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number: ");
                }
            }
        }
    }

    public static void GetOperator()
    {
        while (showMenu == true)
        {
            Console.WriteLine("\nPlease choose your challenge:\n");
            foreach (var value in Enum.GetValues(typeof(MenuEnum.Operator)))
            {
                Console.WriteLine($"{value} {(int)value}");
            }
            menuInput = Console.ReadLine();
            if (
                Enum.TryParse<MenuEnum.Operator>(
                    menuInput,
                    out MenuEnum.Operator menuOperatorParsed
                )
            )
            {
                menuOperator = menuOperatorParsed;
                showMenu = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid number: ");
                showMenu = true;
            }

            GameLogic.Arithmetic(difficulty, menuOperator);
        }
    }
}
