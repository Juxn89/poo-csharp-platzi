// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var batman = new SuperHero();

batman.Id = 1;
batman.Name = "Batman";
batman.CanFly = false;
batman.RealName = "Bruce Wayne";
batman.City = "Gotham";
batman.Powers = new[] { "Rich" };
batman.CanFly = false;

class SuperHero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RealName { get; set; }
    public string City { get; set; }
    public string[] Powers { get; set; }
    public bool CanFly { get; set; }
}