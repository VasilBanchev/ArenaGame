using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Queen : Hero
    {
        public bool HealthRecoverUsed { get; private set; }

        public Queen(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Defend(double damage)
        {
            if (Health < 20 && !HealthRecoverUsed)
            {
                HealthRecoverUsed = true;
                Health += 10;
            }

            return base.Defend(damage);
        }
    }
}
