using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertDemo
{
    public interface IEnemy
    {

    }

    public class NormalEnemy : IEnemy
    {
    }

    public class BossEnemy : IEnemy
    {
        public int ExtraPower => 100;
    }

    public class EnemyFactory
    {
        public IEnemy Create(bool isBoss)
        {
            if (isBoss)
            {
                return new BossEnemy();
            }
            return new NormalEnemy();
        }
        
    }

}
