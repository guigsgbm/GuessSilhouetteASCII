using Domain;

namespace Game.Views;

public class MenuViews
{
    public string PreWelcomeMenu()
    {
        Console.WriteLine($"Hey! Tap your name please:");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine($"Tap again, please");
            name = Console.ReadLine();
        }

        return name;
    }

    public void WelcomeMenu(string name)
    {
        Console.Clear();
        Console.WriteLine($"Welcome, {name}");

        Console.WriteLine($"Press any key to play");
        Console.ReadKey();
    }

    public void PreCharacter(string name)
    {
        Console.Clear();
        Console.WriteLine($"{name}, guess the character...");
    }

    public void PreCharacterCount(int count)
    {
        for (int i = 0; i < count; count--)
        {
            Console.WriteLine($"{count}");
            Thread.Sleep(1000);
        }
    }

    public string CharacterAppearance(Character character)
    {
        Console.Clear();
        Console.WriteLine($"Who is this?\n");

        Console.Write($"{character.SilhouetteJson}");

        Console.WriteLine("Character name:");
        var response = Console.ReadLine();

        while (string.IsNullOrEmpty(response))
        {
            Console.WriteLine($"I didn't get it, tap again please");
            response = Console.ReadLine();
        }

        return response;
    }

    public void CharacterAppearanceResult(bool result) 
    {
        Console.Clear();
        if (result == true)
            Console.WriteLine($"You won, congratulations..");

        else
            Console.WriteLine($"Wrong answer, maybe next time..");

        Console.ReadKey();
    }

    public bool PlayAgain()
    {
        Console.Clear();
        Console.WriteLine($"Do you want to play again? [y/n]");

        var playAgain = Console.ReadLine();

        while (playAgain != "y" && playAgain != "n")
        {
            Console.WriteLine($"Tap again, please: {playAgain}");
            playAgain = Console.ReadLine();
        }

        if (playAgain == "y")
            return true;
        else
            return false;
    }

    public void GoodBye()
    {
        Console.Clear();
        Console.WriteLine($"See Ya   o/");
    }
}
