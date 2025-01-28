using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame;

internal class MenuSystem
{
    public static int xMaxValue;
    public static int yMaxValue;
    public static bool showMenu = true;
    public static string optionChosen = "";
    public static string divider = "*********************************";

    public static void intro()
    {
        int difficultyMode = 0;

        Console.WriteLine(DateTime.Now.ToString());

        Console.WriteLine();
        Console.WriteLine(divider);
        Console.WriteLine("\tMaths Game + - * /");
        Console.WriteLine(divider);
        Console.WriteLine();

        Console.WriteLine("Please tell  me your name: ");
        string name = Console.ReadLine().Trim();
        Console.WriteLine($"Welcome: {name}");

        do
        {
            Console.WriteLine(
                "\nPlease choose your difficulty: "
                    + "\n1 - Easy (Double Digit Sums)"
                    + "\n2 - Medium (Triple Digit Sums"
                    + "\n3 - Hard (Quadruple Digit Sums"
            );

            difficultyMode = int.Parse(Console.ReadLine());

            if (difficultyMode == 1)
            {
                xMaxValue = 10;
                yMaxValue = 10;
            }
            else if (difficultyMode == 2)
            {
                xMaxValue = 100;
                yMaxValue = 100;
            }
            else if (difficultyMode == 3)
            {
                xMaxValue = 1000;
                yMaxValue = 1000;
            }
        } while (difficultyMode == 0);
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine(
            "\n\n*** Menu ***\n\n"
                + "A: for Addition\n"
                + "B: for Subtraction\n"
                + "C: for Multiplication\n"
                + "D: for Division\n"
                + "E: for Random\n"
                + "F: for Score History\n"
                + "X: to Exit"
        );

        Console.Write("\nPlease enter a Menu Choice: ");
        string input = Console.ReadLine().Trim().ToUpper();

        do
        {
            switch (input)
            {
                case "A":
                    optionChosen = "Addition"; // idea: generate dynamically called methods based on the menu choice.
                    MathGame.GameLogic.Arithmetic(optionChosen);
                    break;
                case "B":
                    optionChosen = "Subtraction";
                    MathGame.GameLogic.Arithmetic(optionChosen);
                    break;
                case "C":
                    optionChosen = "Multiplication";
                    MathGame.GameLogic.Arithmetic(optionChosen);
                    break;
                case "D":
                    optionChosen = "Division";
                    MathGame.GameLogic.Arithmetic(optionChosen);
                    break;
                case "E":
                    Random randomGame = new Random();
                    optionChosen = "Random";
                    MathGame.GameLogic.Arithmetic(optionChosen);
                    break;
                case "F":
                    optionChosen = "Score History";
                    MathGame.ScoreKeeper.TotalScore(optionChosen);
                    break;
                case "X":
                    showMenu = false;
                    continue;

                default:
                    Console.Write("Please Enter a valid input: ");

                    break;
            }
        } while (showMenu == true);

        Console.WriteLine("\nThank you for playing, Goodbye!");
        Console.ReadLine();
    }
}
