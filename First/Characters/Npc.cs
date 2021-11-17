using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    class Npc : Character
    {


    public Npc(Character character)
    {
            //if (character.Level < 5)
            //{
                this.Health = GenerateHealth(character.Level);
                this.Level = GenerateLvl(character.Level);
                this.NormalAttack = GenerateAttack(character.Level);
                this.Name = GenerateName();
            //}            
    }
        public override string ToString()
        {
            return $"{Name}: Level: {Level} | Health: {Health} | AttackPower: {NormalAttack}";
        }
        public static int GenerateAttack(int lvl)
        {               
            Random random = new Random();
            return random.Next(1, lvl + 10);
        }
        private int GenerateLvl(int lvl)
        {
            Random random = new Random();
           return random.Next(lvl, lvl + 1);
        }
        private int GenerateHealth(int lvl)
        {
            Random random = new Random();
            return random.Next(10, lvl * 15);
        }
        private string GenerateName()
        {
            Random random = new Random();
            string[] maleNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
            int nameindex = random.Next(maleNames.Length);
            return maleNames[nameindex];
        }

    }
}
