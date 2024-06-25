using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevampSwdDmgFormula

{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage() 
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
       

    }
}
