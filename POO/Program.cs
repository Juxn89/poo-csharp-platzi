using POO.Models;

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

batman.UserSuperPower();
string resultSuperPowers = batman.UserSuperPowers();
Console.WriteLine(resultSuperPowers);
Console.WriteLine(batman.NameAndRealName);
Console.WriteLine(batman.SaveTheLand());
Console.WriteLine(batman.SaveTheWorld());

var wolverine = new AntiHeroe();
wolverine.Id = 2;
wolverine.Name = "Wolverine";
wolverine.RealName = "Logan";
wolverine.Powers = new List<SuperPower>()
{
    new SuperPower() { Name = "Regeneration", Description = "Regeneration", Level = LevelPower.LevelThree },
    new SuperPower() { Name = "Adamantium Claws", Description = "Regeneration", Level = LevelPower.LevelThree }
};

Console.WriteLine( wolverine.DoAntiHereoAction("Attack to polices") );