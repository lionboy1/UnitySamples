using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void AssignPosition(Vector3 pos);
    public static event AssignPosition assign;

    //Call this in unity to fire off the event
    public void DoIt()
    {
        if(assign != null)
        {
            assign(new Vector3(5,2,0));
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(5,2,0);
            assign(pos);
        }
    }    
}
