using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, fwd, Color.red);
        if(Physics.Raycast(transform.position, (fwd), out hit))
        {
            Debug.Log("Detected something!");
        }
    }
}
