using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using MathGame.RyanW84;
using static MathGame.RyanW84.DifficultyEnum;
using static MathGame.RyanW84.GameLogic;
using static MathGame.RyanW84.MenuEnum;

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
        Exit = 6,
    }
}

internal class MenuSystem
{
    public static int xMaxValue;
    public static int yMaxValue;
    public static bool showMenu = true;
    public static string optionChosen = "";
    public static string divider = "***********************************";
    public static int difficultyInput = 0;
    public static int menuInput = 0;
    public static string name;
    public static bool difficultyChosen = false;
    public static string dateTimeStamp = DateTime.Now.ToString();
    public static DifficultyEnum.Difficulty difficulty;
    public static MenuEnum.Operator menuOperator;

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
                if (
                    Enum.TryParse<DifficultyEnum.Difficulty>(
                        Console.ReadLine(),
                        out DifficultyEnum.Difficulty difficulty
                    )
                )
                {
                    difficultyChosen = true;
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

            if (
                Enum.TryParse<MenuEnum.Operator>(
                    Console.ReadLine(),
                    out MenuEnum.Operator menuOperator
                )
            )
            {
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
