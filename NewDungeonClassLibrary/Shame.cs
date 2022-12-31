using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewDungeonClassLibrary
{
    public class Shame : Monster
    {

        public Shame(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, int minDamage, int maxDamage, string description) : base(name, maxHitPoints, hitPoints, defense, accuracy, minDamage, maxDamage, description)
        {

            Name = "Shameful Beast";
            MaxHitPoints = 35;
            HitPoints = 34;
            Defense = 20;
            Accuracy = 100;
            MinDamage = 10;
            MaxDamage = 13;
            Description = "Very cunning, this beast will draw you in with intisive offers, just to take you for everything";


        }

        public Shame() { }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
