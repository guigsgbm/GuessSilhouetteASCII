using Domain;
using Game.Views;
using System.Net.Http.Json;

namespace Game.Controller;


public class GameController
{
    private readonly MenuViews _views;

    private int _count = 3;
    private string _apiUrl = "http://localhost:32777/api/characters/";
    private bool _result;
    private bool playAgain;

    public GameController(MenuViews views)
    {
        _views = views;
    }

    public void Game()
    {
        var name = _views.PreWelcomeMenu();
        _views.WelcomeMenu(name);

        while (true)
        {
            _views.PreCharacter(name);

            _views.PreCharacterCount(_count);

            var character = GetRandomCharacter().Result;
            var response = _views.CharacterAppearance(character);

            if (!response.Equals(character.Name, StringComparison.OrdinalIgnoreCase))
                _result = false;
            else
                _result = true;

            _views.CharacterAppearanceResult(_result);

            playAgain = _views.PlayAgain();

            if (playAgain == false)
                break;
        }

        _views.GoodBye();
    }

    public async Task<Character> GetRandomCharacter()
    {
        using (var httpClient = new HttpClient())
        {
            var characters = await httpClient.GetFromJsonAsync<List<Character>>(_apiUrl);

            if (characters != null)
            {
                Random random = new Random();
                var randomId = random.Next(0, characters.Count);

                var randomChar = characters[randomId];
                return randomChar;
            }

            return null;
        }
    }
}
