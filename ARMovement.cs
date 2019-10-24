using System;
using UnityEngine;

//Vuforia project
namespace AR
{

    public class ARMovement : MonoBehaviour
    {
        //Destination marker goal.
        public GameObject markerGoal;
        //Parent position.
        Vector3 parentPos;
        //Agent
        NavMeshAgent agent;
        
        //Sprite
        public Sprite destSprite;



        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            MoveToTarget();
            Pitch();
        }

        void MoveToTarget()
        {
            if (markerGoal.active)
            {
                parentPos = markerGoal.transform.parent.position;
                agent.SetDestination(parentPos);
                destSprite.transform.position = new Vector3(parentPos.x, 0, parentPos.z);
            }
        }

        //Range set up for pitch of airborne.
        float MapRange(float s, float a1, float a2, float b1, float b2)
        {
            if (s >= a2) return b2;
            if (s <= a1) return b1;
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }

        //Agent leans when moving based on direction
        void Pitch()
        {
            transform.GetChild(0).eulerAngles = new Vector3(
                MapRange(agent.velocity.magnitude, 0f, 2f, 0f, 20f),
                transform.eulerAngles.y,
                transform.eulerAngles.z
                );
        }

    }
}
