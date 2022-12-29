using NewDungeonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace NewDungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            Weapon w1 = new Weapon("Kindness","Enemies are friends who haven't yet been understood", 10, 5, true, WeaponTypes.Understanding );
            
            Character c1 = new Player("Jes" , 50, 50, 100, 100, Origin.None, w1);
            Console.WriteLine(c1);

            Console.WriteLine(w1);
            Console.WriteLine(c1);
            Console.WriteLine(c1.CalcDamage());



        }//end Main()
    }//end class
}//end namespace
