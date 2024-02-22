// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var batmanPower1 = new SuperPower();
batmanPower1.Name = "Rich";
batmanPower1.Description = "💰";
batmanPower1.Level = LevelPower.LevelThree;

var batmanPower2 = new SuperPower();
batmanPower2.Name = "Smart";
batmanPower2.Description = "Smart | Description";
batmanPower2.Level = LevelPower.LevelThree;

var batman = new SuperHero();

batman.Id = 1;
batman.Name = "Batman";
batman.CanFly = false;
batman.RealName = "Bruce Wayne";
batman.City = "Gotham";
batman.Powers = new List<SuperPower>() { batmanPower1, batmanPower2};
batman.CanFly = false;

class SuperHero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RealName { get; set; }
    public string City { get; set; }
    public List<SuperPower> Powers { get; set; }
    public bool CanFly { get; set; }
}

class SuperPower
{
    public string Name { get; set; }
    public string Description { get; set; }
    public LevelPower Level { get; set; }
}

enum LevelPower
{
    LevelOne = 1,
    LevelTwo = 2, 
    LevelThree = 3
}