using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassObjectWithColor : MonoBehaviour
{
    [SerializeField] GameObject cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.black);
        }
    }

    void ChangeColor(GameObject go, Color c)
    {
        go.GetComponent<MeshRenderer>().material.color = c;
        
    }
}
