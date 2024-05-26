using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; }

        public double BlockingPower { get; }

        public int Arrows { get; }

        public Bow(string name, double attack = 22.5)
        {
            Name = name;
            AttackDamage = attack;
            BlockingPower = 0;
        }
    }
}
