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

            Character c1 = new Character("Jes" , 50, 50, 100, 100);
            Console.WriteLine(c1);


        }//end Main()
    }//end class
}//end namespace
