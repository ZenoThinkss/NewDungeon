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
            MaxHitPoints = 35;
            HitPoints = 34;
            Defense = 20;
            Accuracy = 100;
            MinDamage = 10;
            MaxDamage = 13;
            Description = "Initially very charismatic, for those with experience getting close is never an option. Seemingly very confident and outgoing but this is a facade to hide the deep feelings of inadequecy and the fragile state of their sense of being. They are beleived to be a forced evolution of a shame beast. It will protect itself at all cost from feeling shame, inferiority of any kind(even percieved) ortaking responsiblity. They lack self awareness and enrage as well as gather smaller beast to help destroy you if you they percieve you as the source of any of the above.";


        }

        public Ego() { }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
