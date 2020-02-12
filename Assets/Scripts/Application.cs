using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



public class Application : MonoBehaviour
{

    public Model model;
    public View view;
    public Controller controller;
    
    

    

    public void EventsHandler(string p_event_path, Object p_target, params object[] p_data)
    {


        Controller[] controllers_array = GetAllControllers();

        foreach(Controller c in controllers_array)
        {
            c.EventExecution(p_event_path, p_target, p_data);
        }


    }

    public Controller[] GetAllControllers()         
    {


        Controller[] allControllers = controller.transform.GetComponentsInChildren<Controller>();


        return allControllers;
        

    }


}
