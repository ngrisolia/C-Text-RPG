using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_s_2;
using Weapons;

namespace inv_checker
{
    class InvCheck
    {      

        string equipment_type = "";
        int Arraycount = 0;
        int Player_Inventory_GP = 20;
        string Input;
        int correct;
        public static bool Equipment_Open = true;
        
        
        public void Player_Inv()
        {
            
            
            do
            {
                Equipment_Open = true;
                Console.Clear();
                Console.WriteLine("Your inventory:");
                for (Arraycount = 0; Arraycount < 20; Arraycount++)
                {
                    int inventory_position = Arraycount + 1;
                    string inventory_slot_number = "";
                    if (inventory_position == 1)
                    {
                        inventory_slot_number = "1 ";
                    }
                   if (inventory_position == 2)
                    {
                        inventory_slot_number = "2 ";
                    }
                    if (inventory_position == 3)
                    {
                        inventory_slot_number = "3 ";
                    }
                    if (inventory_position == 4)
                    {
                        inventory_slot_number = "4 ";
                    }
                    if (inventory_position == 5)
                    {
                        inventory_slot_number = "5 ";
                    }
                    if (inventory_position == 6)
                    {
                        inventory_slot_number = "6 ";
                    }
                    if (inventory_position == 7)
                    {
                        inventory_slot_number = "7 ";
                    }
                    if (inventory_position == 8)
                    {
                        inventory_slot_number = "8 ";
                    }
                    if (inventory_position == 9)
                    {
                        inventory_slot_number = "9 ";
                    }
                    if (inventory_position == 10)
                    {
                        inventory_slot_number = "10";
                    }
                    if (inventory_position == 11)
                    {
                        inventory_slot_number = "11";
                    }
                    if (inventory_position == 12)
                    {
                        inventory_slot_number = "12";
                    }
                    if (inventory_position == 13)
                    {
                        inventory_slot_number = "13";
                    }
                    if (inventory_position == 14)
                    {
                        inventory_slot_number = "14";
                    }
                    if (inventory_position == 15)
                    {
                        inventory_slot_number = "15";
                    }
                    if (inventory_position == 16)
                    {
                        inventory_slot_number = "16";
                    }
                    if (inventory_position == 17)
                    {
                        inventory_slot_number = "17";
                    }
                    if (inventory_position == 18)
                    {
                        inventory_slot_number = "18";
                    }
                    if (inventory_position == 19)
                    {
                        inventory_slot_number = "19";
                    }
                    if (inventory_position == 20)
                    {
                        inventory_slot_number = "20";
                    }

                    Console.SetCursorPosition(0, inventory_position);
                    Console.WriteLine("{0} > {1}",inventory_slot_number, Inventory[Arraycount]);
                }
                Console.WriteLine();
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("Inventory Max Slots: {0}", Inventory.Length);
                Console.WriteLine("GP: {0}", Player_Inventory_GP);
                Console.WriteLine();
                Console.WriteLine("[1] Equip [2] Unequip [3] Use Item");            
                Console.WriteLine();
                Console.WriteLine("[B] Back");
                Input = Console.ReadLine().ToUpper();
                if (Input == "B")
                {
                    correct = 1;
                }
               
                if (Input == "1" && Equipment_Open == true)
                {

                    Console.WriteLine("> Enter the item slot number of the item you wish to equip:");
                    Input = Console.ReadLine().ToUpper();
                    try
                    {
                        Int32.TryParse(Input, out var x);
                        x -= 1;
                        if (Inventory[x] != null)
                        {
                            // Do inventory adding shit
                            Console.WriteLine("> Equip {0}? Y/N", Inventory[x]);
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "Y" && Equipment[Weapon.ID] == null) //change
                            {
                                Console.WriteLine("> {0} equipped to {1}", Inventory[x], Weapon.equipmentType);
                                Equipment[Weapon.ID] = Weapon.Name;
                                Console.ReadLine();
                                Equipment_Open = false;
                                if (Input == "B")
                                {
                                    correct = 1;
                                    Equipment_Open = false;
                                }
                                if (Input != "B")
                                {
                                    correct = 1;
                                    Equipment_Open = false;
                                }
                            }
                            else if (Input == "Y" && Equipment[Weapon.ID] != null)
                            {
                                Console.WriteLine("> Cannot equip. {0} full", Equipment[Weapon.ID]);
                                Console.ReadLine().ToUpper();
                                Equipment_Open = false;
                            }                           
                        }
                        else
                        {
                        }

                    }
                    catch (Exception ex)
                    {
                        // Invalid number, do other shit
                    }
                }
                if (Input != "1" && Input != "B")
                {
                    correct = 0;
                }



            } while (correct == 0);

            
        }

        //Player Equipment
        public string[] Equipment { get; set; }
        public string[] Equipment_Type { get; set; }
        

        //Switch statement?
        //Use map instead of array for equipment? (Assign key and value. get head. gives back helmet. Define equipment slot, and assign only certain equipment to each?

        
        public void Player_Equipment()
        {

            do
            {
                

                Console.Clear();
                Console.WriteLine("Equipment:");
                for (Arraycount = 0; Arraycount < 9; Arraycount++)
                {
                    int equipment_position = Arraycount + 1;
                    int equipment_slot_type = Arraycount + 1;

                    if (equipment_slot_type == 1)
                    {
                        equipment_type = "1. Head      ";
                    }
                    if (equipment_slot_type == 2)
                    {
                        equipment_type = "2. Neck      ";
                    }
                    if (equipment_slot_type == 3)
                    {
                        equipment_type = "3. Chest     ";
                    }
                    if (equipment_slot_type == 4)
                    {
                        equipment_type = "4. Arms      ";
                    }
                    if (equipment_slot_type == 5)
                    {
                        equipment_type = "5. Hands     ";
                    }
                    if (equipment_slot_type == 6)
                    {
                        equipment_type = "6. Legs      ";
                    }
                    if (equipment_slot_type == 7)
                    {
                        equipment_type = "7. Feet      ";
                    }
                    if (equipment_slot_type == 8)
                    {
                        equipment_type = "8. Main Hand ";
                    }
                    if (equipment_slot_type == 9)
                    {
                        equipment_type = "9. Off Hand  ";
                    }

                    Console.SetCursorPosition(0, equipment_slot_type + equipment_position);                   
                    Console.WriteLine("{0} |  > {1}",equipment_type, Equipment[Arraycount]);
                }
                Console.WriteLine();
                Console.WriteLine("_______________________________________________");
                Console.WriteLine();
                Console.WriteLine("[1] Equip [2] Unequip [3] Use Item");
                Console.WriteLine();
                Console.WriteLine("[B] Back");
                Input = Console.ReadLine().ToUpper();

                


                    if (Input == "1" && Equipment_Open == true)
                    {
                    do
                    {

                        Console.Clear();
                        Player_Inv();
                      //  Console.WriteLine("Enter the item slot number of the item you wish to equip:");
                        Console.WriteLine();
                        Console.WriteLine("[B] Back");
                        Input = Console.ReadLine().ToUpper();
                        try
                        {
                            Int32.TryParse(Input, out var x);
                            x -= 1;
                            if (Inventory[x] != null)
                            {
                                // Do inventory adding shit
                                Console.WriteLine("> Equip {0}? Y/N", Inventory[x]);
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "Y" && Equipment[Weapon.ID] == null)
                                {
                                    Console.WriteLine("> {0} equipped to {1}", Inventory[x], Weapon.equipmentType);
                                    Equipment[Weapon.ID] = Weapon.Name;

                                    Console.ReadLine().ToUpper();
                                }
                                else if (Input == "Y" && Equipment[Weapon.ID] != null)
                                {
                                    Console.WriteLine("> Cannot equip {0} {1} full", Inventory[x], Equipment[Weapon.ID]);
                                    Console.ReadLine().ToUpper();
                                }
                            }
                            else
                            {
                            }

                        }
                        catch (Exception ex)
                        {
                            // Invalid number, do other shit
                        }
                    } while (correct == 0);

                    }
           


                if (Input == "2" && Equipment_Open == true)
                {
                    
                    Console.WriteLine("> Enter the item slot number of the item you wish to unequip:");
                    Input = Console.ReadLine().ToUpper();
                    try
                    {
                        Int32.TryParse(Input, out var y);
                        y -= 1;
                        if (Equipment[y] != null)
                        {
                            // Do inventory adding shit
                            Console.WriteLine("> Unequip {0}? Y/N", Equipment[y]);
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "Y" && Equipment[Weapon.ID] != null)
                            {
                                Console.WriteLine("> {0} unequipped", Equipment[y]);
                                Equipment[Weapon.ID] = null;
                                Console.ReadLine().ToUpper();
                            }
                            
                        }
                        else if (Equipment[y] == null)
                        {
                            Console.WriteLine("> Cannot unequip. Slot empty.");
                            Console.ReadLine().ToUpper();
                        }

                    }
                    catch (Exception ex)
                    {
                        // Invalid number, do other shit
                    }

                }





                if (Input == "B")
                {
                    correct = 1;
                }
                if(Input != "B")
                {

                }
                

            } while (correct == 0);


        }


        public int FindNextOpen()
        {
            for (var i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == null)
                {
                    return i;
                }
            }

            // No Opend space found
            return -1;
        }

        public string[] Inventory { get; set; }
        public InvCheck(string[] slotcheck, string[] equipmentcheck)
        {
            Inventory = slotcheck;
            Equipment = equipmentcheck;
        }
        void Swiggles(string[] args)
        {
            string Input;
            string Item_Name = "Health Potion";
            string Name = "Niralas";

            
            int Player_Item_Amount_Received = 1;
            int correct = 0;
            int Player_Item_Gained = 0;        

            Console.WriteLine("> Accept Item?");
            Input = Console.ReadLine().ToUpper();

            var Inventory_Slot = this.FindNextOpen();

            //if player accepts and has a free slot:
            if (Input == "Y" && Inventory_Slot > -1)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("> {0} gains {1} {2} ", Name, Player_Item_Amount_Received, Item_Name);
                    Console.WriteLine("> Gained Item");
                    Player_Item_Gained = 1;
                    Inventory[Inventory_Slot] = Item_Name;
                    correct = 1;
                } while (correct == 0);


            }

            //if player accepts but there is no free slot
            if (Input == "Y" && Inventory_Slot == -1  && Player_Item_Gained == 0)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("> Slot Full");
                    correct = 1;
                } while (correct == 0);
            }


            //if player declines
            if (Input == "N")
            {
                correct = 1;
            }

            if (Input != "N" || Input != "Y")
            {

            }

            

            if (Input == "INV")
            {
                
            }



            //If yes, checks for freem slot in player inventory


        }
    }
}
