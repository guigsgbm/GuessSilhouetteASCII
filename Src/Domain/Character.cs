using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Domain;

public class Character
{
    public int Id { get; }

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
        One_Piece
    };

    public Character(string name, string description, enumCategory category)
    {
        Name = name;
        Description = description;
        Category = category;
    }

}
