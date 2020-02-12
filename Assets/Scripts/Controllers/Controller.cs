using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : ApplicationAccessor
{


    public static List<Controller> controllers_list = new List<Controller>();


    private void OnEnable()
    {

        controllers_list.Add(this);

    }


    private void OnDisable()
    {

        controllers_list.Remove(this);

    }




    //// Update manager thing
    public virtual void NewUpdate()
    {

    }

    // EventManager thing
    public virtual void EventExecution(string p_event_path, Object p_target, params object[] p_data)
    {

    }









}
