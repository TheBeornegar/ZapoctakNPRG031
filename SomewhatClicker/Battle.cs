using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SomewhatClicker
{
    public class Battle
    {
        public static int MonsterHPLeft, PlayerHPLeft;

        public static int ComputePlayerStrike(int Damage, int CriticalChance)
        {
            Random Rnd = new Random();
            int PlayerRNG = Rnd.Next(100);
            if (PlayerRNG < Atributes.CriticalChance)
            {
                return 2 * Atributes.Damage;
            }
            else
            {
                return Atributes.Damage;
            }
        }

        public static int ComputeMonsterStrike(int Damage, int CriticalChance)
        {
            Random Rnd = new Random();
            int MonsterRNG = Rnd.Next(100);

            if (MonsterRNG < Monsters.MonsterCrit)
            {
                return 2 * Monsters.MonsterDmg;
            }
            else
            {
                return Monsters.MonsterDmg;
            }
        }

        public static Boolean CheckForDeath(int HP)
        {
            if (HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
