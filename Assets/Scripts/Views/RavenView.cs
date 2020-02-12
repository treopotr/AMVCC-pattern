using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenView : View
{

    



    public void OnCollisionEnter(){ app.EventsHandler(EventsAddoner.RavenReactionOnCollision, this); }




}
