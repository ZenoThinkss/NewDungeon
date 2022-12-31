using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeonClassLibrary
{
    public class Combat
    {
       public static void AttackPhase(Character attack, Character defend) 
       {
            
            var roll = new Random().Next(1, 101);
            //slight pause after roll
            Thread.Sleep(200);


            //this needs to be changed up. did put in a cal for evasiveness so have
            //TODO Evasiveness
            
            bool success = roll < attack.CalcAccuracy() - defend.CalcDefense();
            if (success)
            {
                //calc damage
                int damageDealt = attack.CalcDamage();

                //assign the damage to the defender
                defend.HitPoints -= damageDealt;

                //out the result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attack.Name} attacks {defend.Name} for {damageDealt} damage!");
                Console.ResetColor();

            }

            else 
            {
                Console.WriteLine($"{attack.Name} missed...");
            }
            
       }//end attackPhase()


        public static void DoBattle(Player player, Monster monster) 
        {

            AttackPhase(player, monster);
            Console.WriteLine($"{player.Name} Hp: {player.HitPoints}");
            Console.WriteLine($"{monster.Name} Hp: {monster.HitPoints}");
            
                if (monster.HitPoints > 0) 
                {
                 
                    AttackPhase(monster, player);
                
                }
                
        }

        public static void DoRunBattle(Monster monster, Player player) 
        {
            if (monster.HitPoints > 0 && player.HitPoints >0) 
            {
                AttackPhase(monster, player);
            }
        

        
        }


    }
}
