using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitiesController : Controller
{


    public EntitiesBehaviour entitiesBehaviour;

    public override void EventExecution(string p_event_path, Object p_target, params object[] p_data)
    {


        switch (p_event_path)
        {

            #region Raven
            case "raven.reaction.on.collision":

                Debug.Log("Я ворон и я реагирую на коллизию");

                break;



            case "raven.do.like.wolf":

                entitiesBehaviour.RavenDoLikeWolf();

                break;



            case "raven.move.pattern":

                entitiesBehaviour.RavenMovePattern();

                break;




            #endregion

            #region Wolf
            case "wolf.reaction.on.collision":


                Debug.Log("Я волк и я реагирую на коллизию");


                break;

            

            case "wolf.do.like.raven":


                entitiesBehaviour.WolfDoLikeRaven();


                break;

            case "wolf.move.pattern":


                entitiesBehaviour.WolfMovePattern();


                break;
                #endregion

        }



    }




    private bool _ravenDoLikeWolfAndWolfDoLikeRaven = false;
    private bool _normalBehaviour = true;

    public override void NewUpdate()
    {

        if (_normalBehaviour)
        {
            app.EventsHandler(EventsAddoner.RavenMoovePattern, this);
            app.EventsHandler(EventsAddoner.WolfMoovePattern, this);
        }
        


        if (_ravenDoLikeWolfAndWolfDoLikeRaven)
        {
            app.EventsHandler(EventsAddoner.RavenDoLikeWolf, this);
            app.EventsHandler(EventsAddoner.WolfDoLikeRaven, this);
        }


    }










}
