using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomewhatClicker
{
    public static class Atributes
    {
        public static int Level;
        public static int Dexterity;
        public static int Charisma;
        public static int Constitution;
        public static int MaxHP;            //default MaxHP = 50
        public static int CriticalChance;   //default critical chance = 0
        public static int Damage;           //default damage = 5
        public static int AbilityPoints;

        public static void StatUp(ref int atribute)
        {
            if(AbilityPoints > 0)
            {
                AbilityPoints -=1;
                atribute++;
            }
        }

        public static void ResetStat(ref int atribute)
        {
            if(atribute > 1)
            {
                atribute -=1;
                AbilityPoints++;
            }
        }

        public static void LevelUp()
        {
            Level++;
            AbilityPoints += 3;
        }

        public static void ComputeDamage()
        {
            int defaultDamage = 5;
            Damage = (defaultDamage*2 + (Dexterity-1) + (Level-1)) / 2;
        }

        public static void ComputeMaxHP()
        {
            int defaultMaxHP = 50;
            MaxHP = defaultMaxHP + (Level - 1) * 10 + (Constitution-1) * 5;

        }

        public static void ComputeCriticalChance()
        {
            int defaultCriticalChance = 0;
            CriticalChance = defaultCriticalChance + (Charisma - 1) * 7;
            if(CriticalChance > 100)
            {
                CriticalChance = 100;
            }
        }

        public static void ComputeAllStats()
        {
            ComputeDamage();
            ComputeMaxHP();
            ComputeCriticalChance();
        }
    }
}
