using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steinerova_hra_2
{
    public interface IFightable
    {
        //interface určuje jaké meody musí třída implementovat, ale neříká jak je má implementovat (musi ale je dědit)

        void Attack(GameEntity entita, int damage);

        void Defend(int damage);

    }
}
