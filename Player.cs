using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    CharacterController _ccontrol;
    [SerializeField] float speed  = 5f;
    [SerializeField] float gravity = 2f;
    [SerializeField] float jumpHeight = 20f;
    
    //Cache y velocity to prevent snapping at the end of frame
    //when direction is reset to a y value of 0
    float yVelocity;

    void Start()
    {
        _ccontrol = GetComponent<CharacterController>();
        if(_ccontrol == null)
        {
            Debug.Log("No character controller found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horiz, 0, 0);
        Vector3 velocity = direction * speed;

        if(_ccontrol.isGrounded)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpHeight;
            }
        }
        else
        {
            yVelocity -= gravity;
        }
        
        velocity.y = yVelocity;

        _ccontrol.Move(velocity * Time.deltaTime);
    }
}
