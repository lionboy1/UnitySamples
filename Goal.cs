using System;
using UnityEngine;

//Vuforia project

namespace AR
{
	public class Goal : MonoBehaviour
    {
        LineRenderer line;

        void Start()
        {
            line = GetComponent<LineRenderer>();
            line.SetWidth( .05f, .05f);
        }

        void Update()
        {
            //Current position of marker
            line.SetPosition(0, transform.parent.position);
            //Marker position relative to surface.
            line.SetPosition(1, new Vector3(transform.parent.position.x, 0, transform.parent.position.z));
}
