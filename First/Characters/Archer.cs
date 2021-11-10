using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Characters
{
    class Archer : Character
    {
        public int Focus { get; set; }
        public int RangedAttackPower { get; set; }


        public Archer(string aName): base(aName)
        {
            
            this.NormalAttack = 5;
            this.Focus = 80;
            this.Health = 80;
            
        }
        public override string ToString()
        {
            return $"Class: Archer | Health: {Health} | Focus: {Focus} | RangedAttackPower: {RangedAttackPower} | Level: {Level} | Experience: {Experience}/{ExpReqPerLvl}";
        }
    }
}
