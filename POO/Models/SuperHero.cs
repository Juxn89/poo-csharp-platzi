using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models;

internal class SuperHero : Heroe
{
    public SuperHero()
    {
        this.Id = 1;
        this.Powers = new List<SuperPower>();
        this.CanFly = false;
    }

    private string _Name;
    public int Id { get; set; }
    public override string Name { 
        get { return _Name; }
        set { _Name = value.Trim(); }
    }
    public string RealName { get; set; }
    public string City { get; set; }
    public List<SuperPower> Powers { get; set; }
    public bool CanFly { get; set; }
    public string NameAndRealName
    {
        get
        {
            return $"{this.RealName} is {Name}!";
        }
    }

    public void UserSuperPower()
    {
        Powers.ForEach(power => {
            Console.WriteLine($"{Name} is using {power.Name} super power!");
        });
    }

    public string UserSuperPowers()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Powers.ForEach(power => {
            stringBuilder.Append($"{Name} is using {power.Name} super power!");
        });

        return stringBuilder.ToString();
    }

    public override string SaveTheWorld()
    {
        return $"{NameAndRealName} have saved the land!!!";
    }

    public override string SaveTheLand()
    {
        //return base.SaveTheLand();
        return $"The world has been saved by { Name }!";
    }
}
