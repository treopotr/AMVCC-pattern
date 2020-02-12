using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationAccessor : MonoBehaviour
{
    

    public Application app { get { return FindObjectOfType<Application>(); } }



}
