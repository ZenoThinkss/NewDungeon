using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeonClassLibrary
{
    public class Deciet : Monster
    {
     
        public Deciet(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, int minDamage, int maxDamage, string description) : base(name, maxHitPoints, hitPoints, defense, accuracy, minDamage, maxDamage,description)
        {

            Name = "Deceptive Beast";
            //specifically for this monster
            //if statement 
            //do while for battle sequence 

        
        }

        public Deciet() { }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
