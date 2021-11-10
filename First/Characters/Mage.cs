using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    class Mage : Character
    {
        public int Mana { get; set; }
        public int SpellPower { get; set; }

        public Mage(string aName): base(aName)
        {
            this.Health = 50;          
            this.Mana = 100;
            this.SpellPower = 10;
            
        }
        public override string ToString()
        {
            return $"Class: Mage | Health: {Health} | Mana: {Mana} | SpellPower: {SpellPower} | Level: {Level} | Experience: {Experience}/{ExpReqPerLvl}";
        }
    }
}
