using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steinerova_hra_2
{
    public class Enemy : GameEntity
    {
        public bool IsBoss { get; private set; }

        public Enemy(int health, int damage, bool isBoss) : base(health, damage)
        {
            IsBoss = isBoss;
        }

        public override void Attack(GameEntity entity)
        {
            //int attackDamage = IsBoss ? (Damage * 1.1) :Damage;
            //entity.Defend(attackDamage);
        }

        public override void Defend(int damage)
        {
            int reducingDamage = IsBoss ? (int)(damage * 0.86): damage;
            health -= reducingDamage;
        }



    }
}
