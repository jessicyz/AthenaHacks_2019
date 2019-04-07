using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task
{
    //name of task
    string taskName;

    //what kind of task
    //0 for premium, 1 for custom
    int taskType;

    //amount you gain from completing the task
    int amountGained;

    //number of times you can do a task a day
    int numTimesPerDay;
    
    //number of time you've done the task today
    int numTimesToday = 0;
    
    //last time task was done
    //date and time class

    //how long it takes to complete a task
    // num minutes/seconds

    //amount of time cooldown (to prevent people from brushing their teeth and immediately brushing again)
    //num minutes/seconds
    public Task(){

    }

    //return true if it's not on cooldown and you haven't done the task more than the max
    public bool CheckCooldown(){
        if(numTimesToday > numTimesPerDay){
            return false;
        }
        //if the time between the last time you did a task and the current time is < cooldown time, 
        //return false
        
        return true;
    }

}
