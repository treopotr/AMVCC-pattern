using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfView : View
{


    void OnCollisionEnter() { app.EventsHandler(EventsAddoner.WolfReactionOnCollision, this);  }



}
