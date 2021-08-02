using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Dungeon of Lost Souls";
            Console.WriteLine("The darkest of journeys begins...");

            //score running total variable
            int score = 0;

            Race human = new Race("Human", hitPoints: 100, maxHitPoints: 100, accuracy: 55, dodge: 20, description: "The Human is the most balanced of the races but is not particularly strong in any aspect. A jack-of-all-trades, if you will.\n");
            Race elf = new Race("Elf", 85, 85, 70, 40, "The elf boasts high evasion and accuracy with slightly lower fortitude.\n");
            Race ronso = new Race("Ronso", 105, 105, 60, 35, "The ronso has a humanoid figure with the face of a lion. They have a higher fortitude than that of humans.\n");
            Race dwarf = new Race("Dwarf", 110, 110, 65, 35, "The dwarves' small stature makes it slightly harder for them to be hit by attacks.\n");
            Race troll = new Race("Troll", 160, 160, 50, 25, "The troll is a massive creature with unbelievable fortitude, however, it is also very clumsy.\n");
            Race angel = new Race("Angel", 125, 125, 70, 40, "The angels are always ready to fight their holy war.\n");
            Race demon = new Race("Demon", 125, 125, 70, 40, "The demon fears nothing but the holy light of an angel.\n");
            Race[] races = { human, elf, ronso, dwarf, troll, angel, demon };
            //string[] playerRace = new string[8];
            //playerRace[0] = "Human";
            //playerRace[1] = "Elf"; //bow
            //playerRace[2] = "Ronso"; //spear
            //playerRace[3] = "Dwarf"; //hammer
            //playerRace[4] = "Troll"; //axe
            //playerRace[5] = "Angel"; //sword
            //playerRace[6] = "Demon"; //Chain&Sickle
            //playerRace[7] = "Monk"; //gauntlet

            //string[] playerWeapon = new string[7];
            //playerWeapon[0] = "Bow";
            //playerWeapon[1] = "Spear";
            //playerWeapon[2] = "Hammer";
            //playerWeapon[3] = "Axe";
            //playerWeapon[4] = "Sword";
            //playerWeapon[5] = "Sickle & Chain";
            Weapon bow = new Weapon("Bow", 3, 10, 15);
            Weapon spear = new Weapon("Spear", 4, 13, 5);
            Weapon hammer = new Weapon("Hammer", 3, 12, 5);
            Weapon axe = new Weapon("Axe", 1, 20, 0);
            Weapon sword = new Weapon("Sword", 3, 12, 8);
            Weapon sickle = new Weapon("Sickle", 8, 10, 3);
            Weapon[] weapons = { bow, spear, hammer, axe, sword, sickle };
            bool moveForward = false;
            bool startAdventure = false;
            Weapon equippedWeapon = new Weapon("fist", 0, 1, 0);
            Race playerRace = new Race("name", 5, 5, 15, 15, "test race");
            bool exit = false;

            

            do
            {
                Console.WriteLine("What race would you like to play as?\n" +
                    "1) Human\n" +
                    "2) Elf\n" +
                    "3) Ronso\n" +
                    "4) Dwarf\n" +
                    "5) Troll\n" +
                    "6) Angel\n" +
                    "7) Demon");
                ConsoleKey userRace = Console.ReadKey(true).Key;
                switch (userRace)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("{0}\n" +
                            "Continue? Y/N", human);
                        ConsoleKey answer = Console.ReadKey().Key;
                        switch (answer)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = human;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("{0}\n" +
                            "Continue? Y/N", elf);
                        ConsoleKey answer1 = Console.ReadKey().Key;
                        switch (answer1)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = elf;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", ronso);
                        ConsoleKey answer2 = Console.ReadKey().Key;
                        switch (answer2)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = ronso;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", dwarf);
                        ConsoleKey answer3 = Console.ReadKey().Key;
                        switch (answer3)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = dwarf;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", troll);
                        ConsoleKey answer4 = Console.ReadKey().Key;
                        switch (answer4)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = troll;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", angel);
                        ConsoleKey answer5 = Console.ReadKey().Key;
                        switch (answer5)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = angel;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", demon);
                        ConsoleKey answer6 = Console.ReadKey().Key;
                        switch (answer6)
                        {
                            case ConsoleKey.Y:
                                //Console.WriteLine("Good luck on your adventure...");
                                moveForward = true;
                                playerRace = demon;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (!moveForward);

            Console.Clear();
            do
            {
                Console.WriteLine("What is your weapon of choice?\n" +
                    "1) Bow\n" +
                    "2) Spear\n" +
                    "3) Hammer\n" +
                    "4) Axe\n" +
                    "5) Sword\n" +
                    "6) Sickle");
                ConsoleKey userWeapon = Console.ReadKey(true).Key;
                switch (userWeapon)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("{0}\n" +
                            "Continue? Y/N", bow);
                        ConsoleKey weapon = Console.ReadKey().Key;
                        switch (weapon)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = bow;

                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("{0}\n" +
                            "Continue? Y/N", spear);
                        ConsoleKey weapon1 = Console.ReadKey().Key;
                        switch (weapon1)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = spear;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", hammer);
                        ConsoleKey weapon2 = Console.ReadKey().Key;
                        switch (weapon2)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = hammer;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", axe);
                        ConsoleKey weapon3 = Console.ReadKey().Key;
                        switch (weapon3)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = axe;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", sword);
                        ConsoleKey weapon4 = Console.ReadKey().Key;
                        switch (weapon4)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = sword;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("{0}" +
                            "Continue? Y/N", sickle);
                        ConsoleKey weapon5 = Console.ReadKey().Key;
                        switch (weapon5)
                        {
                            case ConsoleKey.Y:
                                Console.WriteLine("Good luck on your adventure...");
                                startAdventure = true; equippedWeapon = sickle;
                                break;
                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid choice.\n\n");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (!startAdventure);

            //Create the player

            Player player = new Player(playerRace.Name, playerRace.HitPoints, playerRace.MaxHitPoints, playerRace.Accuracy, playerRace.Dodge, equippedWeapon);

            if (playerRace.Name == "Elf" && equippedWeapon.Name == "Bow")
            {
                equippedWeapon.MinDamage = 5;
                equippedWeapon.MaxDamage = 12;
                equippedWeapon.AccuracyBonus = 25;
            }

            //Create the outer loop - for the room and monster
            do
            {


                //TODO - Create a monster array
                Monster chimera = new Monster("Chimera", 80, 80, 45, 12, 4, 15, "Two heads, one a bird and the other a lion, with a snake for a tail.");
                Monster wraith = new Monster("Wraith", 35, 35, 55, 25, 1, 6, "Ghostly being that moves through surfaces.");
                Monster bossChinchilla = new Monster("Chinchilla", 100, 100, 55, 20, 4, 12, "This doesn't seem like a normal chinchilla..");
                Monster baseChinchilla = new Monster("Chinchilla", 25, 25, 45, 25, 1, 5, "A mere little rodent.");
                Monster drake = new Monster("Drake", 75, 75, 45, 20, 4, 16, "This creature may be dangerous.");
                Monster malboro = new Monster("Malboro", 65, 65, 50, 15, 3, 13, "A monstrosity with tentacles protruding all over it's body.");
                Vampire v1 = new Vampire("Vampire", 40, 40, 50, 25, 1, 16, "The scourge of the night.");
                Monster[] monsters = { v1, baseChinchilla, drake, malboro, wraith, chimera };
                //Create a room

                if (score == 9)
                {
                    Console.WriteLine(GetFinalRoom());
                }
                else
                {
                    Console.WriteLine(GetRoom());
                }
                //Randomly select a monster to fight
                Random mon = new Random();
                int randomNbr = mon.Next(monsters.Length);
                Monster monster = new Monster();
                if (score == 9)
                {
                    monster = bossChinchilla;
                }
                else
                {
                    monster = monsters[randomNbr];
                }

                //Show the monster in the room
                Console.WriteLine("\nIn this room: " + monster.Name);

                //Inner loop for menu
                bool reload = false;

                do
                {
                    //Create a menu
                    #region Menu
                    Console.Write("\nPlease Choose an Action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Clear the console after the user chooses
                    Console.Clear();

                    //Build our menu functionality
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack");
                            Combat.playerAttack(player, monster);
                            if (monster.HitPoints > 0)
                            {
                                Combat.monsterAttack(monster, player);
                            }
                            if (monster.HitPoints <= 0)
                            {
                                //monster is dead.. you could put some logic here to have the player get a bonus, loot, or something similar due to defeating the monster.
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n",
                                    monster.Name);
                                Console.ResetColor();
                                //reload a new room and monster

                                //add to the player's score
                                score++;
                                //TODO - Handle game restart
                                if (score == 10)
                                {
                                    Console.WriteLine("Congratulations, you have cleared the game!\n");
                                    exit = true;
                                }
                                else
                                {
                                    reload = true;
                                }
                            }
                            break;
                        //Handle Attack Functionality
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away");
                            //Handle Run Away Logic
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.monsterAttack(monster, player);
                            Console.WriteLine();
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //Handle showing player info
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            //Handle showing monster info
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Shutting down application..");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Entry invalid. Try again");
                            break;
                    }//end switch
                    #endregion

                } while (!exit && !reload);
            } while (!exit);

            //This will display the score for the user upon exiting the program
            Console.WriteLine("You defeated " + score +
                " monster" + (score == 1 ? "." : "s."));
        }//end Main()

        private static string GetRoom()
        {
            //Create a collection of different rooms.
            string[] rooms =
            {
                "Several exits lead from this room, but only one is within the mouth of a man. The door opposite you stands within an intricate stone carving of a man's wide-open mouth. The man's nose and eyes loom over the door while his sculpted hair splays out across the wall on either side.",
                "You open the door and a gout of flame rushes at your face. A wave of heat strikes you at the same time and light fills the hall. The room beyond the door is ablaze! An inferno engulfs the place, clinging to bare rock and burning without fuel.",
                "Many doors fill the room ahead. Doors of varied shape, size, and design are set in every wall and even the ceiling and floor. Barely a hand's width lies between one door and the next. All the doors but the one you entered by are shut, and many have obvious locks.",
                "Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.",
                "This small room is lined with benchlike seats on all the walls. The seats all have holes in their top, like a privy. Facing stones on the front of the benches prevent you from seeing how deep the holes go. It looks like a communal bathroom.",
                "This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.",
                "This room holds six dry circular basins large enough to hold a man and a dry fountain at its center. All possess chipped carvings of merfolk and other sea creatures. It looks like this room once served some group of people as a bath.",
                "A liquid-filled pit extends to every wall of this chamber. The liquid lies about 10 feet below your feet and is so murky that you can't see its bottom. The room smells sour. A rope bridge extends from your door to the room's other exit.",
                "A cluster of low crates surrounds a barrel in the center of this chamber. Atop the barrel lies a stack of copper coins and two stacks of cards, one face up. Meanwhile, atop each crate rests a fan of five face-down playing cards. A thin layer of dust covers everything. Clearly someone meant to return to their game of cards.",
                "This chamber is clearly a prison. Small barred cells line the walls, leaving a 15-foot-wide pathway for a guard to walk. Channels run down either side of the path next to the cages, probably to allow the prisoners' waste to flow through the grates on the other side of the room. The cells appear empty but your vantage point doesn't allow you to see the full extent of them all.",
            };
            //Generate a random object
            Random rand = new Random();
            //Generate a random index number using Next()
            int indexNbr = rand.Next(rooms.Length - 1);
            //Create a string for the single room that will be returned
            string room = rooms[indexNbr];
            //Return the room
            return room;
        }//end GetRoom

        public static string GetFinalRoom()
        {
            string finalRoom = "This is the final room, you can feel that the exit is right on the other side. The floor is cluttered with piles of bones and bodies. What could possibly be awaiting you in this room...";

            return finalRoom;
        }
    }
}
