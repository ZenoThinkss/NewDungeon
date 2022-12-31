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
            Name = name;
            Description = description;
            MaxHitPoints = maxHitPoints;
            HitPoints = hitPoints;
            Defense = defense;
            Accuracy = accuracy;
            MaxDamage= maxDamage;
            MinDamage= minDamage;
            
         
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

          Deciet deciet = new Deciet("Decietful Beast" , 40, 30, 13, 0, 3, 4, "Very Deceptive...");

          Regret regret = new Regret("Regretful Beast", 20, 10, 49, 23, 4, 5, "So very regretful....");

          Shame shame = new Shame("Shameful Beast", 40, 30, 13, 0, 3, 4, "Shameful little guy...");

          Ego ego = new Ego("Deceptive Beast", 40, 30, 13, 0, 3, 4, "What a funny little guy...");


            var lie = new Deciet();
            var missedOpportunity = new Regret();
            var embarassment = new Shame();
            var littleGuy = new Ego();


            List<Monster> monsters = new List<Monster>()
            {

                deciet, littleGuy, regret, littleGuy, embarassment, ego, deciet, shame, lie, lie, 
                missedOpportunity, missedOpportunity, littleGuy, shame, regret, littleGuy, lie, embarassment,
                littleGuy, embarassment, littleGuy


            };


            int randomNbr = new Random().Next(monsters.Count);
            Monster monster = monsters[randomNbr];
            return monster;
        }

        



    }//end class
}//end namespace
