using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatters : MonoBehaviour
{
    Vector3[] positions;
    int rID;

    void Start()
    {
        positions[0] = new Vector3(0,4,0);
        positions[1] = new Vector3(1,3,1);
        positions[2] = new Vector3(2,2,2);
        positions[3] = new Vector3(3,1,3);
        positions[4] = new Vector3(4,0,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomIndex()
    {
        rID = Random.Range(0,6);
    }

    void SetPosition(Vector3 p)
    {
        for(int i = 0; i < positions.Length; i++)
        {
            
        }
    }
}
