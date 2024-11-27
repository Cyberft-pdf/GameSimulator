using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Steinerova_hra_2
{
    public class Player : GameEntity, IHealable
    {
        public int Armor { get; set; }

        public Player(int health, int damage,int armor) : base(health,damage)
        {
            Armor = armor;
        }

                            //aby každy mohl utočit na každého
        public override void Attack(GameEntity enemak)
        {
            if (enemak.isAlive)
            {
                enemak.health -= damage;

                if (enemak.isAlive)
                {
                    Console.WriteLine("Enemák pořád žije. Utočím znovu");
                    health = Math.Min(health + 15, 100);
                }
                else { Console.WriteLine($"Enemák byl zabit!"); }
            }
            else
            {
                Console.WriteLine("Enemák je již mrtev");
            }

        }

        public override void Defend(int damage)
        {
            int remainingDamage = damage;
            if (Armor > 0)
            {
                if (Armor >= remainingDamage)
                {
                    Armor -= remainingDamage;
                    remainingDamage = 0;
                }
                else
                {
                    remainingDamage -= Armor;
                    Armor = 0;
                }
            }

            health -= remainingDamage;
        }

        public void Heal(int health)
        {
            base.health = Math.Min(base.health + health, 100);
            /*
             
            Aktuální zdraví: 80
            Léčení: 30
            Když zavolám Heal(30)

            Spočítá se nové zdraví 80 + 30 = 110
            Math.Min vybere menší hodnotu mezi 110 a 100 a výsledek je 100
            Zdraví hráče (Health) se nastaví na 100
                  
             
             */
        }
    }
}
