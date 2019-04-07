using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularTaskList
{
    //A list of all tasks in the game

    //maximum number of tasks. 
    //Is a fixed size because regular tasks will not be added in code
    public static int maxNumTasks = 10;
    public static Task[] arr_tasks = new Task[maxNumTasks];

    public RegularTaskList(){
        //populate arr_tasks with the tasks

    }


}
