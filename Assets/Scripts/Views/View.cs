using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : ApplicationAccessor
{

    public RavenView ravenView;
    public WolfView wolfView;

    void Awake()
    {
        ravenView = GetComponentInChildren<RavenView>();
        wolfView = GetComponentInChildren<WolfView>();
    }



}
