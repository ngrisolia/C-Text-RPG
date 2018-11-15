using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_s_2
{
    class Inv_Checker
    {

        public static int FindNextOpen(string[] Inventory)
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

        static void Main(string[] args)
        {
            string Input;
            int correct = 0;

            //Draw Inventory

            Console.WriteLine("Accept Item?");
            Input = Console.ReadLine().ToUpper();

            var Inventory_Slot = FindNextOpen(Inventory);

            //if player accepts and has a free slot:
            if (Input == "Y" && Inventory_Slot > -1)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("> {0} gains {1} {2} ", Name, Player_Item_Amount_Received, Item_Name);
                    Console.WriteLine("Gained Item");
                    Player_Item_Gained = 1;
                    Inventory[Inventory_Slot] = Item_Name;
                    correct = 1;
                } while (correct == 0);


            }

            //if player accepts but there is no free slot
            if (Input == "Y" && Inventory_Slot == -1 && Player_Item_Gained == 0)
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

            if (Input != "N" || Input != "Y")
            {

            }

            void Player_Inv()
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Your inventory:");
                    for (Arraycount = 0; Arraycount < 20; Arraycount++)
                    {
                        int inventory_position = Arraycount + 1;
                        Console.SetCursorPosition(0, inventory_position);
                        Console.WriteLine("> {0}", Inventory[Arraycount]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("_______________________________________________");
                    Console.WriteLine("Inventory Max Slots: {0}", Inventory.Length);
                    Console.WriteLine("GP: {0}", Player_Inventory_GP);
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

            if (Input == "INV")
            {
                Player_Inv();
            }



            //If yes, checks for freem slot in player inventory


        }
    }
}
