using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    UIManager _ui;
    CharacterController _ccontrol;
    [SerializeField] float speed  = 5f;
    [SerializeField] float gravity = 2f;
    [SerializeField] float jumpHeight = 18f;
    bool inAir;
    
    //Cache y velocity to prevent snapping at the end of frame
    //when direction is reset to a y value of 0
    float yVelocity;
    int _coins;

    void Start()
    {
        _ccontrol = GetComponent<CharacterController>();
        if(_ccontrol == null)
        {
            Debug.Log("No character controller found!");
        }
        _ui = GameObject.Find("Canvas").GetComponent<UIManager>();
         if(_ui == null)
        {
            Debug.Log("No UI Manager found!");
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
            inAir = false;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpHeight;
                inAir = true;
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(inAir)
                {
                    yVelocity += jumpHeight;
                    inAir = false;
                }
            }
            yVelocity -= gravity;
        }
        
        velocity.y = yVelocity;

        _ccontrol.Move(velocity * Time.deltaTime);
    }

    public void AddCoins()
    {
        _coins++;
        _ui.UpdateCoinAmount(_coins);
    }
}
