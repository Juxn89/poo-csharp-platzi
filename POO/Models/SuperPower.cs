using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models;

internal class SuperPower
{
    public SuperPower()
    {
        this.Level = LevelPower.LevelOne;
    }

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
