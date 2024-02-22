
namespace POO.Models;
internal class AntiHeroe : SuperHero
{
    public string DoAntiHereoAction(string action)
    {
        return $"Anti-hero {this.Name} had done: { action }";
    }
}