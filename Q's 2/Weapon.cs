using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inv_checker;




namespace Weapons
{
    public class Weapon
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string NamePlural { get; set; }
        public static int WeaponAttackBonus { get; set; }

        public static string equipmentType { get; set; }

        public Weapon(int id, string name, string namePlural, string equipment_type, int weapon_attack_bonus)
        {

            ID = id;
            Name = name;
            NamePlural = namePlural;
            equipmentType = equipment_type;
            WeaponAttackBonus = weapon_attack_bonus;

        }
        

        //  public Weapon()
        // {
        //     int id = ID;
        //     string name = Name;
        //     string namePlural = NamePlural;
        //     int weapon_attack_bonus = WeaponAttackBonus;
        //    string equipment_type = equipmentType;
        //}


        //public Sword(int id, string name, string namePlural, string equipment_type, int weapon_attack_bonus)
        // {
        //    ID = id;
        //    Name = name;
        //    NamePlural = NamePlural;
        //    equipmentType = equipment_type;
        //    WeaponAttackBonus = weapon_attack_bonus;
        //}






        //  public Weapon : Weapon
        // {
        //    public string equipment_type = "8. Main Hand ";
        //    public int ID = 7;
        //    public string Name = "Longsword";
        //    public string NamePlural = "Longswords";
        //    public int WeaponAttackBonus = 2;

        // public Longsword(int id, string name, string namePlural, string equipmentType, int weaponAttackBonus)
        // {
        //     ID = id;
        //     Name = name;
        //     NamePlural = namePlural;
        //     weaponAttackBonus = WeaponAttackBonus;

        // }
        //}

    }


}
