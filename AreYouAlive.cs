using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(health > 0)
            {
                Damage();
            }
        }
    }
    void Damage()
    {
        health -= Random.Range(20, 50);
        if(health <= 0)
        {
            health = 0;
            Debug.Log("Player is dead");
        }
    }
}
