using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barberian : Hero
    {
        public int AbilityDamage { get; set; }

        public Barberian(string name, double armor, double strenght, IWeapon weapon, int abilityDamage) : base(name, armor, strenght, weapon)
        {
            AbilityDamage = abilityDamage;
        }

        public override double Attack()
        {
            bool isAbilityActive = new Random().Next(0,100) % 5 == 0;

            double damage = Strenght + Weapon.AttackDamage;

            double totalDamage = isAbilityActive ?  damage + AbilityDamage : damage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);

            return realDamage;
        }
    }
}
