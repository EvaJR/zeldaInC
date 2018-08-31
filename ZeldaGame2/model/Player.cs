using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Player
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public string Name { get; set; }

        // create an inventory of Items
        public List<Item> Inventory { get; set; } = new List<Item>();
        public int RupeeTotal { get; set; } = 0;
        public Item EquippedWeapon { get; set; }

        //function to show inventory
        public void ShowInventory()
        {

            Console.WriteLine("*** INVENTORY ***");
            Console.WriteLine(" Rupees: " + RupeeTotal);
            if (Inventory.Count == 0)
            {
                Console.WriteLine(" Your inventory is empty");
            } else
            {
                Console.WriteLine(" Weapons (press e to equip a weapon)");
                foreach (Item item in Inventory)
                {

                    Console.WriteLine("  * " + item.Name);
                }
                if (EquippedWeapon != null)
                {
                    Console.WriteLine(" Currently equipped: " + EquippedWeapon.Name);
                }
                
            }

        }

        public void EquipWeapon()
        {
            int count = 0;
            Console.WriteLine("Which weapon do you want to equip?");

            foreach (Item weapon in Inventory)
            {
                count += 1;
                Console.WriteLine(count + ". " + weapon.Name);

            }
            try {
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                if (UserChoice >= 1 && UserChoice <= count)
                {
                    EquippedWeapon = Inventory[UserChoice - 1];
                    Console.WriteLine("Equipped " + EquippedWeapon.Name);
                }
            }//TODO add tryParse? }
            catch(System.FormatException)
            { Console.WriteLine("Invalid input."); }

        }

        public Player(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

    }
}
