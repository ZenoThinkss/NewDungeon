using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeonClassLibrary
{
    public class Player : Character
    {
        //Fields 

        //Properties
        public Origin PlayerOrigin { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors

        public Player(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, Origin playerOrigin, Weapon equippedWeapon) : base(name, maxHitPoints, hitPoints, defense, accuracy)
        {
            PlayerOrigin = playerOrigin;
            EquippedWeapon = equippedWeapon;
        }

        public string GetOriginDescription(Origin playerOrigin) 
        {
            return playerOrigin switch
            {

                Origin.None => " ",
                Origin.Saint => "Saint",
                Origin.Philospher => "Philospher",
                Origin.Prophet => "Prophet",
                Origin.Shaman => "Shaman",
                Origin.Reincarnate => "Reincarnate",
                Origin.Commoner => "Commoner",

            };
            
        
        }//end GetOrigin

        public override string ToString()
        {
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: {GetOriginDescription(PlayerOrigin)}";
        }

        public override int CalcAccuracy()
        {
            return Accuracy;//This needs work TODO Changes to accuracy calcs
        }


        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }















    }//end class
}//end namespace
