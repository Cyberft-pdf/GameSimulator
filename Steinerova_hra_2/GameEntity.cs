using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Steinerova_hra_2
{
    public abstract class GameEntity
    {
        public int health { get; set; }
        public int damage { get; set; }
        public bool isAlive => health > 0;

        public GameEntity(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
        }

        public abstract void Attack(GameEntity entity);
        public abstract void Defend(int damage);

    }
}
