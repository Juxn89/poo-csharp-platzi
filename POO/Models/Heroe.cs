using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal abstract class Heroe
    {
        public abstract string Name { get; set; }
        public abstract string SaveTheWorld();
        public virtual string SaveTheLand()
        {
            return $"{this.Name} have saved the land.";
        }
    }
}
