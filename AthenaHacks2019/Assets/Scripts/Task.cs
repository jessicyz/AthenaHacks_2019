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

    //number of times you can do a task a day. 
    //Custom tasks can be done as many times as the user wants
    int numTimesPerDay;
    
    //number of time you've done the task today
    int numTimesToday = 0;
    
    //last time task was done
    //date and time class

    //how long it takes to complete a task
    // num minutes/seconds

    //amount of time cooldown (to prevent people from brushing their teeth and immediately brushing again)
    //Custom tasks have no cooldown
    //num minutes/seconds
    public Task(){

    }


    //for regular and custom tasks
    //No cooldown and no limit on the number of times you've done something
    public Task(string name, int type, int amount){
        taskName = name;
        taskType = type;
        amountGained = amount;
    }

    //for regular tasks
    //set cooldown and limit the number of times
    public Task(string name, int amount, int times, int cooldown){    
        //later add whatever class we're using to calculate time to this constructor.
        //Temporarily an int for now
        taskName = name;
        taskType = 0;
        amountGained = amount;
        numTimesPerDay = times;
        //cooldown
    }


    //return true if it's not on cooldown and you haven't done the task more than the max
    public bool CheckCooldown(){
        if(taskType == 0 && numTimesToday > numTimesPerDay){
            return false;
        }
        //if the time between the last time you did a task and the current time is < cooldown time, 
        //return false

        return true;
    }

    

}
