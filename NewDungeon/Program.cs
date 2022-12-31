using NewDungeonClassLibrary;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace NewDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction/Title

            string welcome = "Welcome, To our Path To Pave";
            string title = "Dungeon";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcome.Length / 2)) + "}", welcome));
            Console.Title = title;

            #endregion

            #region Player Creation

            int score = 0;

            Weapon choice = new Weapon("Courage", "Highly effective in battle", 10, 6, false, WeaponTypes.Honesty);

            Player player = new Player("Pope", 30, 10, 30, 100, Origin.Saint, choice);


            #endregion

            #region   Main Loop

            

            bool quit = false;
            do
            {
                //TODO Center the room string this method isnt working
                Console.Clear();
                string room = GetRoom();
                string roomFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (room.Length / 2)) + "}", room));
                Console.WriteLine(roomFormat);


                Monster monster = Monster.GetMonster();


                string monster1 = ($" You've encountered {monster.Name}");//this line is broken lol
                string monsterFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (monster1.Length / 2)) + "}", monster1));
                Console.WriteLine(monsterFormat);

                #region Game loop

                bool reload = false;
                do
                {

                    #region Menu

                    
                    string opOne = "  W)-Attack-";
                    string opTwo = " S)-Exit- ";
                    string opThree = "  A)-Player-";
                    string opFour = "   D)-Monster-";
                    string opFive = "R)-Run-";
                    string borderTop = " ===========";
                    string borderBottom = " ===========";
                    string option = " What will you do?\n";
                    string opOneFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (opOne.Length / 2)) + "}", opOne));
                    string opTwoFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (opTwo.Length / 2)) + "}", opTwo));
                    string opThreeFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (opThree.Length / 2)) + "}", opThree));
                    string opFourFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (opFour.Length / 2)) + "}", opFour));
                    string opFiveFormat = (String.Format("{0," + ((Console.WindowWidth / 2) + (opFive.Length / 2)) + "}", opFive));
                    string optionF = (String.Format("{0," + ((Console.WindowWidth / 2) + (option.Length / 2)) + "}", option));
                    string borderTopF = (String.Format("{0," + ((Console.WindowWidth / 2) + (borderTop.Length / 2)) + "}", borderTop));
                    string borderBottomF = (String.Format("{0," + ((Console.WindowWidth / 2) + (borderBottom.Length / 2)) + "}", borderBottom));


                    Console.WriteLine(optionF);
                    Console.WriteLine(borderTopF);
                    Console.WriteLine($"{opOneFormat}\n" +
                        $"{opThreeFormat}\n" +
                        $"{opFourFormat}\n" +
                        $"{opFiveFormat}\n" +
                        $"{opTwoFormat}");
                    Console.WriteLine(borderTopF);
                    string menuChoice = Console.ReadKey(true).Key.ToString().ToLower();

                    #endregion


                    switch (menuChoice ) 
                    {
                        case "w":
                            //attacking sequence
                            Console.WriteLine("Attacking!!");
                            Combat.DoBattle(player,monster);
                            if (monster.HitPoints <= 0)
                            {
                                Console.WriteLine($"\nYou conquered {monster.Name}.");
                                Console.ReadKey(true);
                                score++;

                                player.HitPoints += (player.MaxHitPoints / 5);
                                reload = true;
                                                        
                            }
                            
                            break;

                        case "a":
                            //player info
                            Console.WriteLine($"Player:\n {player}");
                            Console.WriteLine($"Score: {score}");
                            break;

                        case "d":
                            //monster info
                            Console.WriteLine($"Player:\n +  {monster}");

                            break;

                        case "r":
                            //run sequence
                            Console.WriteLine("Attempting to escape...");
                            Thread.Sleep(200);

                            Console.WriteLine($"{monster.Name} attacks as you attempt to run...");
                            Combat.DoRunBattle(monster,player);
                            string[] runChance = {"you were hit but got away...", "you stumbled as you tried to flee....", "you ran as fast as you could, it hit you got away for now", "you failed to exscape"," you jumped over the beast but it caught your leg on the way out...." };
                            Console.WriteLine();

                            
                            reload= true;
                            break;

                        case "s":
                        case "x":
                        case "e":
                        case "Escape":
                            CenterString("Thanks for playing!!!");
                            quit= true;
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again....");
                            break;                    
                    }//end switch

                    if (player.HitPoints <= 0) 
                    {
                        Console.WriteLine("No one evades death.....");
                        Thread.Sleep(200);
                        Console.ReadKey(true);
                        quit = true;
                    }

                } while (!reload && !quit);

                #endregion

            } while (!quit);

            #endregion

        }//end Main()



        //Custom get room Method
        #region custom room Method

       

        private static string GetRoom()
        {


            //int  orignalWidth = Console.WindowWidth;
            //int orignalHeight = Console.WindowHeight;

            

            string[][] rooms = new string[3][];

            

            rooms[0] = new string[3]
            {
                 "\n\nSmall room wet, mildewy smell, dimly lit by candles attached to the wall, cob webs covering the corner and the single small round table in the corner\n\n",
                "\n\nsmall room with nothing but a chest on the opposite side of the entrance ",
                        "room with no light\n\n"



            };

           

            rooms[1] = new string[4]
            {
                     "\n\nmedium room with bright light that is almost blinding  you have to cover your eyes with your hand like a visor in order to see\n\n",
                    "\n\nmedium room with only a single light coming in from a small window toward the top of one of the walls the light lands on a door across the room from you\n\n",
                     "\n\nmedium room with a dining table spanning from one side of the room to the other with delicious smelling food is laid out across it\n\n",
                     "\n\nMedium room to help out \n\n"


            };

            


            rooms[2] = new string[5]
            {

                     "\n\nlarge sized room with what looks to be a set of large dog kennels across the left and right walls\n\n",
                    "\n\nLarge room with plants hanging from the cieling and a fountain in the center\n\n",
                     "\n\nLarge room with a very low ceiling you have to crouch to enter\n\n",
                     "\n\n another large room for test\n\n",
                     "\n\n one more large room\n\n"

            };




            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index][index];


            /*originalWidth = 120;
             originalHeight = 30;*/

            if (room == rooms[0][0] || room == rooms[0][1] || room == rooms[0][2])
            {

                
                Console.SetWindowSize(70,20);
                return room;

            }
            else if (room == rooms[2][0] || room == rooms[2][1] || room == rooms[2][2])
            {
                Console.SetWindowSize(120, 40);
                
                return room;
            }
            else
            {
                Console.SetWindowSize(90, 20);
                return room;

            }

            

        }//end GetRoom()


        #endregion

        #region centerFormat method

        public static void CenterString(string s)
        {


            //***********THIS DOES NOT WORK IF THE WINDOW SIZE CHANGES****************

            //declare an int that is equal to the width of the console window - the length of the string 
            //if the console window is 50 and string is 11 then leftPadding = 11
            //PadLeft() takes the leftPadding 11 and adds string length in this case 11 to the padding 
            //with the string itsefl that leaves us at ending the string at 33
            //the pad right will hopefully fill the remaining space 
            //so 11 and 11 on left 22 , then the string 11 , then right padding takes the remainder leaving us as close to center as possible? maybe refactor later 
           
            
            //int leftPadding = (Console.WindowWidth - s.Length);


            //int padLeft = s.PadLeft(leftPadding + s.Length);
            //int padRight =  s.PadRight(leftPadding - s.Length);
           // Console.WriteLine(s.PadLeft(leftPadding + s.Length).PadRight(Console.WindowWidth));
        
            


        }


        #endregion




    }//end class
}//end namespace