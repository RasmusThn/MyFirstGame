using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    class Archer : Character
    {
        public Archer()
        {

        }
        
        public Archer(string aName): base(aName)
        {
            this.Class = "Archer";
            this.Health = 80;
            this.MaxHealth = 80;
            this.SpecialEnergy = 75;
            this.MaxSpecialEnergy = 75;
            this.SpecialPower = 7;
            this.NormalAttack = 3;
            
            
            
        }

        public Archer(Character character):base(character)
        {
           
        }

        public override string ToString()
        {
            return $"Class: Archer | Health: {Health}/{MaxHealth} | Focus: {SpecialEnergy}/{MaxSpecialEnergy} | RangedAttackPower: {SpecialPower}" +
                $" | Level: {Level} | Experience: {Experience}/{ExpReqPerLvl}";
        }
        public override void LevelUp(Character userChar)
        {
            base.LevelUp(userChar);
            userChar.MaxHealth += 15;
            userChar.Health = userChar.MaxHealth;
            userChar.MaxSpecialEnergy += 15;
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
                Console.WriteLine("You are out of Focus, 1 SpecialAttack cost 10 Focus");
                return 0;
            }
        }
    }
}
