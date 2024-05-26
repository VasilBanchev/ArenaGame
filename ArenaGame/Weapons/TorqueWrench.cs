using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class TorqueWrench : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower {  get; private set; }


        public TorqueWrench(string name, double attackDamage = 80, int blockingPower = 0)
        {
            Name = name;
            AttackDamage = attackDamage;
            BlockingPower = blockingPower;
        }
    }
}
