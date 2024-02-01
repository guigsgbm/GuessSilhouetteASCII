namespace Domain;

public class Character
{
    public int Id { get; set; }

    public string Name 
    {
        get { return _name; }
        private set {  _name = value; } 
    }
    private string _name;

    public string Description 
    {
        get { return _description; }
        set { _description = value; } 
    }
    private string _description;

    public enumCategory Category
    {
        get { return _category; }
        private set { _category = value; }
    }
    private enumCategory _category;
    public enum enumCategory
    {
        Dragon_Ball,
        Naruto,
        One_Piece,
        Scooby_Doo,
        Simpsons,
        Phineas_and_Ferb
    };

    private string _silhouetteJson;
    public string SilhouetteJson
    {
        get { return _silhouetteJson; }
        set { _silhouetteJson = value; }
    }
     
    public Character(string name, string description, enumCategory category, string silhouetteJson)
    {
        Name = name;
        Description = description;
        Category = category;
        SilhouetteJson = silhouetteJson;
    }

}
