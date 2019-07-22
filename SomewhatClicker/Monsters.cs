using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomewhatClicker
{
    public class Monsters
    {
        public static int MonsterHP;
        public static  int MonsterDmg;
        public static int MonsterCrit;

        public static void ComputeMonsterHP()
        {
            if(Atributes.Level < 4)
            {
                MonsterHP = 45 + Atributes.Level * 5;
            }
            else
            {
                MonsterHP = 50 + Atributes.Level * Atributes.Level;
            }

        }

        public static void ComputeMonsterDmg()
        {
            if(Atributes.Level < 3)
            {
                MonsterDmg = Atributes.Level * 2;
            }
            else if(Atributes.Level < 6)
            {
                MonsterDmg = 2 + Atributes.Level * 3;
            }
            else
            {
                MonsterDmg = 1 + Atributes.Level * 4;
            }

        }

        public static void ComputeMonsterCrit()
        {
            MonsterCrit = Atributes.Level * 4;
            if(MonsterCrit > 100)
            {
                MonsterCrit = 100;
            }
        }
    }
}
