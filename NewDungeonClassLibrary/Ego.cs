using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewDungeonClassLibrary
{
    public class Ego : Monster
    {
        public Ego(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, int minDamage, int maxDamage, string description) : base (name, maxHitPoints, hitPoints, defense, accuracy, minDamage, maxDamage, description)
        {

            Name = "Egoic Beast";
            //specifically for this monster
            //if statement 
            //do while for battle sequence 


        }

        public Ego() { }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
