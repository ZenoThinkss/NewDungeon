using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewDungeonClassLibrary
{
    public class Regret : Monster
    {

        public Regret(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, int minDamage, int maxDamage, string description) : base(name, maxHitPoints, hitPoints, defense, accuracy, minDamage, maxDamage, description)
        {

            Name = "Regretful Beast";
            //specifically for this monster
            //if statement 
            //do while for battle sequence 


        }

        public Regret() { }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
