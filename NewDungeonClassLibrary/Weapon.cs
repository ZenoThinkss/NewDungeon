using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeonClassLibrary
{
    public class Weapon
    {

        //Fields - Funny
        private string _name;
        private string _description;
        private int _maxDamage;
        private int _minDamage;      
        private bool _isPassive;
        private WeaponTypes _type;

        //Properties - People

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }

        public int MinDamage { get { return _minDamage;} set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; } }

        public bool IsPassive { get { return _isPassive;} set { _isPassive = value; } }

        public WeaponTypes Type { get { return _type; } set { _type = value; } }


        //Constructors - Collect

        public Weapon(string name, string description, int maxDamage, int minDamage, bool isPassive, WeaponTypes type) 
        {

            Name = name;
            Description = description;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            IsPassive = isPassive;
            Type = type;        
        
        }

        public string GetWeaponDescription(WeaponTypes playerWeapon)
        {
            return playerWeapon switch
            {

                WeaponTypes.Understanding => "Perceptivity",
                WeaponTypes.Honesty => "Pricipality",
                WeaponTypes.Humility=> "Modesty",
                WeaponTypes.Authenicity => "Genuity",
                WeaponTypes.Respect => "Regard",
            };


        }//end GetWeapon Description



        //Methods - Monkeys

        public override string ToString()
        {
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage";
        }




    }//end class
}//end namespace
