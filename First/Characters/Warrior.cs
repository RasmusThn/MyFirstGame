using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Warrior : Character
    {
        public Warrior()
        {

        }
        public Warrior(string aName):base (aName)
        {
            this.Class = "Warrior";
            this.Health = 100;
            this.MaxHealth = 100;
            this.SpecialEnergy = 50;
            this.MaxSpecialEnergy = 50;
            this.SpecialPower = 6;
            this.NormalAttack = 4;
        }

        public Warrior(Character character):base(character)
        {
           
            
        }

        public override string ToString()
        {
            return $"{Name}:  Level: {Level} | Health: {Health} | Rage: {SpecialEnergy} | AttackPower: {SpecialPower}" +
                $" | Experience: {Experience}/{ExpReqPerLvl}";
        }

        public override void LevelUp(Character userChar)
        {
            base.LevelUp(userChar);
            userChar.MaxHealth += userChar.Level + 20;
            userChar.Health = userChar.MaxHealth;
            userChar.MaxSpecialEnergy += userChar.Level + 10;
            userChar.SpecialEnergy = userChar.MaxSpecialEnergy;
            userChar.SpecialPower += SpecialPower / 2;
            userChar.NormalAttack += NormalAttack / 2;

        }
        public override int SpecialAttackMethod(Character userChar)
        {
            if (userChar.SpecialEnergy > 11)
            {
                userChar.SpecialEnergy -= 10;

                return base.SpecialAttackMethod(userChar);
            }
            else
            {
                Console.WriteLine("You are out of Rage, 1 SpecialAttack cost 10 Rage");
                return 0;
            }
        }
    }
}
