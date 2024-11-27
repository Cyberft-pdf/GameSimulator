using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steinerova_hra_2
{
    public class Game
    {
        public Guid ID { get; }
        public List<Player> Players { get; set; } = new List<Player>(); //list pro uchování hráčů 
        public List<Enemy> Enemys { get; set; } = new List<Enemy>();

        public Game(Guid iD)
        {
            ID = new Guid();
        }

        public void Play(GameResult result)
        {                 
            while (Players.Any(p => p.isAlive) && Enemys.Any(e => e.isAlive))
            {
                ExecutePlayersTurn();
                ExecuteEnemiesTurn();
            }

        }

        public void ExecutePlayersTurn()
        {
            //zase zjištovaní jesli jsou naživu a pak iterovat cyklem, a nechat je se bít pomocí Attack()



        }
        public void ExecuteEnemiesTurn()
        {
            //zase zjištovaní jesli jsou naživu a pak iterovat cyklem, a nechat je se bít pomocí Attack()


        }
    }
    public enum GameResult
    {
        PlayerWin,
        EnemyWin
    }
}
