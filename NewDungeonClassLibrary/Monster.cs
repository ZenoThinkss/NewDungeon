using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeonClassLibrary
{
    public class Monster : Character
    {

        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }

        }

        public Monster() { }

        public Monster(string name, int maxHitPoints, int hitPoints, int defense, int accuracy, int minDamage, int maxDamage, string description) : base(name, maxHitPoints, hitPoints, defense, accuracy) 
        {

            MaxDamage= maxDamage;
            MinDamage= minDamage;
            Description= description;
         
        }

        public override string ToString()
        {
            return $"----------- Monster ----------------\n" +
                $"{base.ToString()}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Description: {Description}";
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage,MaxDamage + 1);
        }


        public static Monster GetMonster()
        {

            Monster monster = new Monster("Monster", 50, 30, 26, 100, 21, 24, "This be a Monster.");

            List<Monster> monsters = new List<Monster> {monster, monster, monster };

            return monsters[new Random().Next(monsters.Count)];
             
        }
        



    }//end class
}//end namespace
