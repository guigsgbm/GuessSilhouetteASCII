using Domain;
using Game.Controller;
using Game.Views;
using System.Net.Http.Json;

/*
using (var httpClient = new HttpClient())
{
    var characters = await httpClient.GetFromJsonAsync<List<Character>>("http://localhost:5041/api/characters/");

    var response = await httpClient.GetFromJsonAsync<Character>("http://localhost:5041/api/characters/12");

    if (characters.Count > 0)
    {
        Random random = new Random();
        var randomId = random.Next(0, characters.Count);

        var randomChar = characters[randomId];

        Console.WriteLine(randomChar.Name);
        Console.WriteLine(randomChar.SilhouetteJson);
    }

    //Console.WriteLine(response.SilhouetteJson);
    Console.WriteLine(characters.Count);
}
*/

var views = new MenuViews();
var controller = new GameController(views);

controller.Game();