using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    internal class Boss : Character
    {
        public Boss(Character character)
        {
            this.Level = character.Level;
            this.Health = GenerateHealth(character.Level);
            this.Name = GenerateName();
            this.NormalAttack = GenerateAttack(character.Level);
            this.Class = "Boss";
        }
        public override string ToString()
        {
            return $"{Name}: Level: {Level} | Health: {Health} | AttackPower: {NormalAttack}";
        }
        private int GenerateAttack(int lvl)
        {
            Random random = new Random();
            return random.Next(5, lvl * 6 );
        }
        private int GenerateHealth(int lvl)
        {
            Random random = new Random();
            return random.Next(lvl * 50, lvl * 100 / 2);
        }
        private string GenerateName()
        {
            Random random = new Random();
            string[] maleNames = { "Wayne Cole", "Edward Bates", "Robert Bakula", "William Von-jones",
                          "Harold Bundy", "Henry Night", "Paul Cady", "Jack Carroll" };
            int nameindex = random.Next(maleNames.Length);
            return maleNames[nameindex];
        }


    }
}
