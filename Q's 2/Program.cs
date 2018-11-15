using inv_checker;
using System;
using Weapons;


namespace Q_s_2
{


    class Program
    {
           
        

        static void Main(string[] args)
        {


            Weapon Longsword = new Weapon(7, "Longsword", "Longswords", "8. Main Hand ", 2);
          













            //Weapon Shortsword = new Weapon();
            //Weapon.ID = 7;
            //Weapon.Name = "Shortsword";
            // Weapon.NamePlural = "Shortswords";
            // Weapon.equipment_type = "8. Main Hand ";
            // Weapon.WeaponAttackBonus = 1;


            //ints
            int chosen = 1;
            int Player_One_Handed = 0;
            int Player_Two_Handed = 0;
            int Player_Magic = 0;
            int Player_Ranged_Weapon = 0;
            int correct = 0;
            int Arraycount = 0;
            //Player
            int Player_Attack_Type = 0;
            int Player_One_Handed_Damage = 2;
            int Player_Two_Handed_Damage = 2;
            int Player_Ranged_Damage = 2;
            int Player_Magic_Damage = 2;
            int Player_Level_Up_Health_Points = 0;
            int Player_Health_Points = 20;
            int Player_Max_Health_Points = Player_Health_Points + Player_Level_Up_Health_Points;
            int Player_Mana_Points = 0;
            int Player_Level_Up_Mana_Points = 0;
            int Player_Max_Mana_Points = Player_Mana_Points + Player_Level_Up_Mana_Points;
            int Enemy_Health_Points;
            int Enemy_Maximum_Damage;
            int Player_Inventory_GP = 0;
            int Player_Inventory_Experience = 0;
            int Player_Quest_Reward_EXP;
            int Player_Quest_Reward_GP;
            int Player_Quest_Progress = 0;
            int Player_Quest_Goal;
            int Player_EXP = 0;
            int Player_Question_1 = 0;
            int Player_Question_2 = 0;
            int Player_Question_3 = 0;
            int Player_Question_4 = 0;
            int Player_Item_Amount_Received;
            int Player_Inventory_Slot_Free;
            int Player_Inventory_Slot_Full = 0;
            int Player_Item_Offer = 0;
            int Player_Item_Gained = 0;


            //strings
            string Name;
            string Race;
            string Class;
            string Player_Class;
            string Player_Race;
            //Inventories
            string[] Inventory = new string[20];
            string[] Equipment = new string[9];
            string[] Equipment_Type = new string[7];
            string[] Equipment_Slot = new string[8];
            string[] Irabor_Inventory = new string[20];
            string Input;
            string Enemy_Name;
            string Player_Quest = " ";
            string Quest_Accepted;
            string Player_Quest_Enemy;
            string Item_Name;
            //bools
            bool charName = false;

            //Inventory Class
            InvCheck InvChecker = new InvCheck(Inventory, Equipment);
            InvCheck InvSlotCheck = new InvCheck(Inventory, Equipment);


            Console.Title = "Lich Quest";
            do
            {
                Console.WriteLine("Enter your name");
                Name = Console.ReadLine();
                if (Name.Length <= 2)
                {
                    Console.WriteLine("Please enter a valid name");

                }
                if (Name.Length > 2)
                {
                    Console.WriteLine("Your name is " + Name);
                    charName = true;
                }
            } while (charName == false);

            do
            {


                //Race
                Console.Clear();
                Console.WriteLine("Pick a race from below. Racial bonuses will appear before finalizing your decision.");
                Console.WriteLine();
                Console.WriteLine("[1] Human");
                Console.WriteLine("[2] Elf");
                Console.WriteLine("[3] Dwarf");
                Player_Race = Console.ReadLine().ToUpper();
                if (Player_Race == "1")
                {


                    correct = 0;
                    Console.Clear();
                    Console.WriteLine("Human Racial Bonuses:");
                    Console.WriteLine();
                    Console.WriteLine("One Handed Weapons: [+1pt]");
                    Console.WriteLine("Two Handed Weapons: [+1pt]");
                    Console.WriteLine("Ranged Weapons:     [+1pt]");
                    Console.WriteLine("Magic:              [+1pt]");
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to play as a Human? Y/N");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "Y")
                    {
                        do
                        {


                            Player_Race = "Human";
                            correct = 1;
                            Player_One_Handed++;
                            Player_Two_Handed++;
                            Player_Magic++;
                            Player_Ranged_Weapon++;

                        } while (correct == 0);

                    }
                    if (Input == "N")
                    {
                        correct = 0;
                    }

                } 
                
                if (Player_Race == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Elves have the following racial bonuses:");
                    Console.WriteLine();
                    Console.WriteLine("One Handed Weapons: [+1pt]");
                    Console.WriteLine("Two Handed Weapons: [N/A]");
                    Console.WriteLine("Ranged Weapons:     [+2pts]");
                    Console.WriteLine("Magic:              [+2pts]");
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to play as an Elf? Enter Y/N");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "Y")
                    {
                        Player_Race = "Elf";
                        correct = 1;
                        Player_One_Handed++;
                        Player_Magic = Player_Magic + 2;
                        Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                    }
                    if (Input == "N")
                    {
                        correct = 0;
                    }
                }
               


                    if (Player_Race == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Dwarves have the following racial bonuses:");
                        Console.WriteLine();
                        Console.WriteLine("One Handed Weapons: [+1pt]");
                        Console.WriteLine("Two Handed Weapons: [+2pts]");
                        Console.WriteLine("Ranged Weapons:     [+1pt]");
                        Console.WriteLine("Magic:              [N/A]");
                        Console.WriteLine();
                        Console.WriteLine("Do you wish to play as a Dwarf? Y/N");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "Y")
                        {
                            Player_Race = "Dwarf";
                            correct = 1;
                            Player_One_Handed++;
                            Player_Two_Handed = Player_Two_Handed + 2;
                            Player_Ranged_Weapon++;
                        }
                        if (Input == "N")
                        {
                            correct = 0;
                        }

                    }
                
            } while (correct == 0);




            correct = 0;

            //Class
            do
            {
                Console.Clear();
                Console.WriteLine("Pick a class from below:");
                Console.WriteLine("[1] Knight");
                Console.WriteLine("[2] Archer");
                Console.WriteLine("[3] Cleric");
                Player_Class = Console.ReadLine().ToUpper();
                if (Player_Class == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Knights have the following class bonuses:");
                    Console.WriteLine();
                    Console.WriteLine("One Handed Weapons: [+1pt]");
                    Console.WriteLine("Two Handed Weapons: [+2pts]");
                    Console.WriteLine("Ranged Weapons:     [N/A]");
                    Console.WriteLine("Magic:              [N/A]");
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to play as a Knight? Y/N");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "Y")
                    {
                        Player_Class = "Knight";
                        correct = 1;
                        Inventory[0] = Weapon.Name; Inventory[1] = "HEY"; Inventory[2] = "Health Potion";
                        Player_One_Handed++;
                        Player_Two_Handed = Player_Two_Handed + 2;
                    }
                    if (Input == "N")
                    {
                        correct = 0;
                    }
                }
                if (Player_Class == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Archers have the following class bonuses:");
                    Console.WriteLine();
                    Console.WriteLine("One Handed Weapons: [+1pt]");
                    Console.WriteLine("Two Handed Weapons: [+0pts]");
                    Console.WriteLine("Ranged Weapons:     [+2pts]");
                    Console.WriteLine("Magic:              [N/A]");
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to play as an Archer? Y/N");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "Y")
                    {
                        Player_Class = "Archer";
                        correct = 1;
                        Inventory[0] = "Bow"; Inventory[1] = "Quiver"; Inventory[2] = "Arrows"; Inventory[3] = "Health Potion";
                        Player_One_Handed++;
                        Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                    }
                    if (Input == "N")
                    {
                        correct = 0;
                    }
                }
                if (Player_Class == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Clerics have the following class bonuses:");
                    Console.WriteLine();
                    Console.WriteLine("One Handed Weapons: [+2pt]");
                    Console.WriteLine("Two Handed Weapons: [+0pts]");
                    Console.WriteLine("Ranged Weapons:     [+0pts]");
                    Console.WriteLine("Magic:              [+2pts]");
                    Console.WriteLine();
                    Console.WriteLine("Do you wish to play as a Cleric? Y/N");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "Y")
                    {
                        Player_Class = "Cleric";
                        correct = 1;
                        Inventory[1] = "Holy Water Vial"; Inventory[2] = "Health Potion";
                        Player_One_Handed = Player_One_Handed + 2;
                        Player_Magic = Player_Magic + 2;
                    }
                    if (Input == "N")
                    {
                        correct = 0;
                    }
                    else { }

                }
            }
            while (correct == 0);
            correct = 0;

            //Player Description
            Console.Clear();
            Console.WriteLine("Your character:");
            Console.WriteLine();
            Console.WriteLine("A {0} {1}", Player_Race, Player_Class);
            Console.WriteLine();
            Console.WriteLine("Skills:");
            Console.WriteLine();
            Console.WriteLine("> One Handed Weapons: [{0}]", Player_One_Handed);
            Console.WriteLine("> Two Handed Weapons: [{0}]", Player_Two_Handed);
            Console.WriteLine("> Ranged Weapons:     [{0}]", Player_Ranged_Weapon);
            Console.WriteLine("> Magic:              [{0}]", Player_Magic);
            Console.ReadLine();

            //Inventory[0] = "a"; Inventory[1] = "b"; Inventory[2] = "snails";

            //Console.Clear();
            //Console.WriteLine("Inventory Test: type inventory below");
            //Input = Console.ReadLine().ToUpper();
            //Inventory System:
            //if (Input == "INVENTORY" || Input == "INV")
            //{
            //   Console.Clear();
            //   Console.WriteLine("Your Inventory Contains:");
            //  for (Arraycount = 0; Arraycount < 20; Arraycount++)
            //  {
            //    int inventory_position = Arraycount + 1;
            //    Console.SetCursorPosition(0, inventory_position);
            //    Console.WriteLine("{0}", Inventory[Arraycount]);
            // }
            // }
            //else
            //{
            //}

            //Random int 0-100
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            //Enemies
            Enemy_Name = "Rat";
            Enemy_Health_Points = 12;
            Enemy_Maximum_Damage = 2;






            //Quest Giving
            //Player_Quest_Reward_GP = 50;
            //Player_Quest_Reward_EXP = 15;
            //Player_Quest_Goal = 3;
            //Player_Quest_Enemy = "Rats";

            // do
            // {
            //     correct = 0;
            //    Console.Clear();
            //    if (Player_Quest != " ")
            //    {
            //       Console.WriteLine("You must finish your current quest in order to get a new one.");
            //       correct = 1;
            //   }
            //  if (Player_Quest == " ")
            //  {
            //     Console.WriteLine("I have a rat infestation in my fields. They are runing my crops! I will gladly reward you for killing all 3 of them");
            //      Console.WriteLine("> Quest Reward: {0} Gold Pieces and {1} Skill Points", Player_Quest_Reward_GP, Player_Quest_Reward_EXP);
            //     Console.WriteLine("Accept Quest? Yes/No");
            //     Input = Console.ReadLine().ToUpper();
            //     if (Input == "NO")
            //     {
            //        correct = 1;
            //        Quest_Accepted = "NO";
            //    }
            //    if (Input == "YES")
            //   {
            //       Console.WriteLine("You have accepted the quest");
            //       Player_Quest = "The farmer would gladly pay you 50 Gold Pieces ands 15 EXP for ridding his field of the three Rats.";
            //     correct = 1;
            //      Quest_Accepted = "YES";
            //   }
            // }
            //
            // } while (correct == 0);
            //  Console.ReadLine();





            //Tutorial Quest, Introduction
            Console.ReadLine();
            Console.WriteLine("Let us begin...");
            Console.ReadLine();
            string title = @"
   __ _      _         ____                 _                                           
  / /(_) ___| |__     /___ \_   _  ___  ___| |_                                         
 / / | |/ __| '_ \   //  / / | | |/ _ \/ __| __|                                        
/ /__| | (__| | | | / \_/ /| |_| |  __/\__ \ |_                                         
\____/_|\___|_| |_| \___,_\ \__,_|\___||___/\__|                                        
                                                                                        
                Press Enter to Start ";
            Console.Clear();
            Console.WriteLine(title);
            Console.Read();
           


            

            do
            {              
                Player_Quest = "Reach Destination";            
                //Quest
                Player_Quest_Reward_GP = 50;
                Player_Quest_Reward_EXP = 15;
                Player_Quest_Goal = 1;
                Player_Quest_Enemy = "";
                correct = 0;
                //Quest
                Console.Clear();
                Console.WriteLine("You are traveling in a horse-drawn carriage along a a dirt road through the Weeping Wetlands, a thick swamp looming with Cyprus trees.");
                Console.WriteLine("'The elves live here.' Says the man steering the carriage. 'Keep an eye on any bodies of water we pass. You may see some of their scouts peeking above the surface at us.'");
                Console.WriteLine("'Don't worry, we're allowed passage on this road, as long as we don't cause any trouble.'");
                Console.WriteLine("The man takes out a pipe and lights it. The wooden carriage creaks as it continues down the road, passing over dirt and rock.");
                Console.WriteLine("------------------"); //18
                Console.WriteLine("Actions: ");
                Console.WriteLine("------------------"); //18
                Console.WriteLine("[1] Menu");
                Console.WriteLine("[2] Look Inside");
                Console.WriteLine("[3] Look Outside");
                Console.WriteLine("[4] Speak");
                Input = Console.ReadLine();

                if (Input == "1")
                {
                    do
                    {
                        correct = 0;
                        Console.Clear();
                        Console.WriteLine("[1] Quests");
                        Console.WriteLine("[2] Inventory");
                        Console.WriteLine("[3] Status");
                        Console.WriteLine("[4] Equipment");
                        Console.WriteLine();
                        Console.WriteLine("[B] Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "1" && Player_Quest != " ")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine(Player_Quest);
                                Console.WriteLine("________________");
                                Console.WriteLine("Progress: {0}/{1} {2}", Player_Quest_Progress, Player_Quest_Goal, Player_Quest_Enemy);
                                Console.WriteLine();
                                Console.WriteLine("[B] Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }
                            } while (correct == 0);
                        }
                        //Inventory
                        if (Input == "2")
                        {
                            InvChecker.Player_Inv();
                            
                        }
                       
                        if (Input == "B")
                        {
                            correct = 1;
                        }
                        if (Input != "B")
                        {
                        }

                        if (Input == "3")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("{0}'s Status: ", Name);
                                Console.WriteLine();
                                Console.WriteLine("Health Points: [{0}]", Player_Health_Points);
                                Console.WriteLine("Mana Points:   [{0}]", Player_Mana_Points);
                                Console.WriteLine("Race: {0} | Class: {1} |", Player_Race, Player_Class);
                                Console.WriteLine();
                                Console.WriteLine("One Handed Weapons: [{0}]", Player_One_Handed);
                                Console.WriteLine("Two Handed Weapons: [{0}]", Player_Two_Handed);
                                Console.WriteLine("Ranged Weapons:     [{0}]", Player_Ranged_Weapon);
                                Console.WriteLine("Magic:              [{0}]", Player_Magic);

                                Console.WriteLine();
                                Console.WriteLine("[B] Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }
                            } while (correct == 0);
                            if (Input == "B")
                            {
                                correct = 1;
                            }
                            if (Input != "B")
                            {
                            }

                        }
                        //Equipment
                        if (Input == "4")
                        {
                            InvChecker.Player_Equipment();                                                        
                        }
                    
                        if (Input == "B")
                        {
                            correct = 1;
                        }
                        if (Input != "B")
                        {
                        }

                    } while (correct == 0);


                }

                if (Input == "2")
                {
                    do
                    {
                        correct = 0;
                        Console.Clear();
                        Console.WriteLine("You look around the carriage. You are the only passenger. The carriage is empty besides yourself and the items in your bag.");
                        Console.WriteLine();
                        Console.WriteLine("[B] Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "B")
                        {
                            correct = 1;
                        }
                        if (Input != "B")
                        {
                        }
                    } while (correct == 0);
                }

                if (Input == "3")
                {
                    do
                    {
                        correct = 0;
                        Console.Clear();
                        Console.WriteLine("You look out the carriage windows. On your left you see dark, dense forest. On your right you see more sparse forest with a body of water going through it.");
                        Console.WriteLine("You swear you could make out a pair of eyes peering at you from the water, just before a tree blocks your view.");
                        Console.WriteLine();
                        Console.WriteLine("[B] Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "B")
                        {
                            correct = 1;
                        }
                        if (Input != "B")
                        {
                        }
                    } while (correct == 0);
                }


                if (Input == "4")
                {
                    do
                    {   
                        correct = 0;
                        Console.Clear();
                        Console.WriteLine("'Yes, what would you like to know about?' asks the Man steering the carriage.");
                        Console.WriteLine();
                        Console.WriteLine("[1] The Man");
                        Console.WriteLine("[2] History");
                        Console.WriteLine("[3] Advice");
                        Console.WriteLine("[4] Trade");
                        Console.WriteLine();
                        Console.WriteLine("[B] Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "1")
                        {
                            do
                            {
                                correct = 0;
                                Console.Clear();
                                Console.WriteLine("'Oh me? I am just a carriage driver. Been doing this for years. I've retired quite a bit ago.'");
                                Console.WriteLine("'My real name is Irabor. I was once a young Alchemist, damn good at it too. Now I just drive this carriage for some extra penny.'");
                                Console.WriteLine();
                                Console.WriteLine("[B] Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }

                            } while (correct == 0);
                        }
                        if (Input == "2")
                        {
                            do
                            {
                                correct = 0;
                                Console.Clear();
                                Console.WriteLine("'That's a long answer. I'll give you the short one,' laughs the Man.");
                                Console.WriteLine("'The Weeping Wetlands once was home to Goblins. The Elves came and drove them away, saving us all from countless raids, kindappings, and other mischief.'");
                                Console.WriteLine("'Some say that the Goblins plan to eventually take back the Wetlands. We'll see about that,' scoffs the Man.");
                                Console.WriteLine();
                                Console.WriteLine("[B] Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }
                            } while (correct == 0);
                        }

                        if (Input == "3")
                        {
                            do
                            {
                                correct = 0;
                                Player_Item_Amount_Received = 1;
                                Item_Name = "Health Potion";
                                Console.Clear();
                                Console.WriteLine("'My best advice I could give you? Don't anger anybody. The elves in these parts have high tempers.'");
                                Console.WriteLine("'Here, this may help you in time of need.'");
                                Console.WriteLine("The man reaches his hand through a small window that allows him to see into the carriage behind him.");
                                Console.WriteLine("In his hand is a glass vial containing a red liquid.");
                                Console.WriteLine();
                                Console.WriteLine("The Man offers you {0} {1}.", Player_Item_Amount_Received, Item_Name);
                                Console.WriteLine();
                                Console.WriteLine("> Y/N?");
                                Input = Console.ReadLine().ToUpper();


                                //Has player received item offer yet?

                                //if player accepts and has a free slot:
                                var openslot = InvChecker.FindNextOpen();
                                if (Input == "Y" && openslot > -1)
                                {
                                    InvChecker.Inventory[openslot] = "Health Potion";
                                    Console.WriteLine("{0} Added to Slot {1}", Item_Name, InvChecker.FindNextOpen());                                    
                                    Player_Item_Gained = 1;
                                    correct = 1;
                                    Console.ReadLine();
                                }

                                //if player accepts but there is no free slot
                                if (Input == "Y" && Inventory[0] != null && Player_Item_Gained == 0)
                                {
                                    do
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Slot Full");
                                        correct = 1;
                                    } while (correct == 0);
                                }
                                

                                //if player declines
                                if (Input == "N")
                                {
                                    correct = 1;
                                }

                                if(Input != "N" || Input != "Y")
                                {

                                }
                                    
                               


                                //If yes, checks for freem slot in player inventory


                                Console.WriteLine();
                                Console.WriteLine("[B] Back");
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }
                            } while (correct == 0);
                            correct = 0;
                        }
                        if (Input == "4")
                        {
                            Irabor_Inventory[0] = "20 Gold Pieces"; Irabor_Inventory[1] = "Dagger"; Irabor_Inventory[2] = "Book";
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Their Inventory: ");
                                //Trade System:
                                for (Arraycount = 0; Arraycount < 20; Arraycount++)
                                {
                                    int inventory_position = Arraycount + 1;
                                    Console.SetCursorPosition(0, inventory_position);
                                    Console.WriteLine("> {0}", Irabor_Inventory[Arraycount]);
                                }
                                Console.WriteLine("[B] Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "B")
                                {
                                    correct = 1;
                                }
                                if (Input != "B")
                                {
                                }

                            } while (correct == 0);
                        }
                        if (Input == "B")
                        {
                            correct = 1;
                        }
                        if (Input != "B")
                        {
                        }



                    } while (correct == 0);



                }

                //Menu Quest Writeout

               

                

            } while (correct != 3);

            //Combat System

            
        }
    }
}


 





















            










        



