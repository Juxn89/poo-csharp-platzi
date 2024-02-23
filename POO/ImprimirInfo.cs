using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHero(ISuperHeroe superHero) {
            Console.WriteLine($"ID: { superHero.Id }");
            Console.WriteLine($"Name: { superHero.Name }");
            Console.WriteLine($"Real name: { superHero.RealName }");
        }
    }
}
