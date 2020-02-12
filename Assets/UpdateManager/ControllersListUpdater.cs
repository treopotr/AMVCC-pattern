using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllersListUpdater : MonoBehaviour
{


    public void Update()
    {

        for (int i = 0; i < Controller.controllers_list.Count; i++)
        {

            Controller.controllers_list[i].NewUpdate();

        }


    }






}
