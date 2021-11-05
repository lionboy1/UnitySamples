using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.assign += ChangePosition;//Add the ChangePosition back to the delegate which it matches so objects subscribing to it will execute their code
    }

    void ChangePosition(Vector3 pos)
    {
        transform.position = pos;
    }

    //De-subscribe as good practice when done.
    void OnDisable()
    {
        Main.assign -= ChangePosition;
    }
}
