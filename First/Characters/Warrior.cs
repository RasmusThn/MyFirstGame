using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Warrior : Character
    {
        public int Rage { get; set; }
        public int AttackPower { get; set; }

        public Warrior(string aName):base (aName)
        {
            this.Health = 100;
            //this.Level = 1;
            this.Rage = 50;
            this.AttackPower = 5; 
        }
        public override string ToString()
        {
            return $"Class: Warrior | Health: {Health} | Rage: {Rage} \n\n AttackPower: {AttackPower} | Level: {Level} | Experience: {Experience}/{ExpReqPerLvl}";
        }
    }
}
