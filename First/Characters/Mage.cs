using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    class Mage : Character
    {
        public Mage()
        {

        }
        public Mage(string aName): base(aName)
        {
            this.Class = "Mage";
            this.Health = 60;
            this.MaxHealth = 60;
            this.SpecialEnergy = 100;
            this.MaxSpecialEnergy = 100;
            this.SpecialPower = 10;
            this.NormalAttack = 2;
            
        }
        public Mage(Character character):base(character)
        {
            
        }

        public override string ToString()
        {
            return $"{Name}:  Class: Mage | Health: {Health}/{MaxHealth} | Mana: {SpecialEnergy}/{MaxSpecialEnergy} | SpellPower: {SpecialPower} " +
                $"| Level: {Level} | Experience: {Experience}/{ExpReqPerLvl}";
        }
        public override void LevelUp(Character userChar)
        {
            base.LevelUp(userChar);
            userChar.MaxHealth += 10;
            userChar.Health = userChar.MaxHealth;
            userChar.MaxSpecialEnergy += 20;
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
                Console.WriteLine("You are out of Mana, 1 SpecialAttack cost 10 Mana");
                return 0;
            }
        }
    }
}
