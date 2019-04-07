using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager
{
    //name of villager
    string name;
    //name of sprite. 
    //gameObject.GetComponent<SpriteRenderer> ().sprite = Resources.Load("img1", typeof(Sprite)) as Sprite;
    string sprite;
    //how rare it is, for determining rates
    //int rarity;
    //name of task, in order to find the task that it modifies
    string taskName;
    //amount it increases the amount of currence you get by.
    float bonus;
    public Villager(){

    }
    public Villager(string name_, string sprite_, string taskName_, float bonuss_){
        name = name_;
        sprite = sprite_;
        //rarity = rarity_;
        taskName = taskName_;
        bonus = bonuss_;
    }
}
