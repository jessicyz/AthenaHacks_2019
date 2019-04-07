using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerList
{
    //A list of all villagers in the game

    //maximum number of villagers. 
    //Is a fixed size because villagers will not be added in code
    public static int maxNumVillagers = 10;
    public static Villager[] arr_villagers = new Villager[maxNumVillagers];

    public VillagerList(){
        //populate arr_villagers with the villagers
    }


}
