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
    [SerializeField] int _lives = 3;
    [SerializeField] Transform _spawn;
    [SerializeField] Transform _frog;
    bool inAir;
    Transform _lasPos;
    [SerializeField] Transform right;
    [SerializeField] Transform left;
    [SerializeField] Animator m_animator;
    
    //Cache y velocity to prevent snapping at the end of frame
    //when direction is reset to a y value of 0
    float yVelocity;
    int _coins;
    float yRot;

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
        m_animator = GetComponentInChildren<Animator>();
        if(m_animator == null)
        {
            Debug.LogError("No animator component found!");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horiz, 0, 0);
        Vector3 velocity = direction * speed;

        if(_ccontrol.isGrounded)
        {
            inAir = false;
            if(Input.GetKey(KeyCode.Space) && !inAir)
            {
                yVelocity = jumpHeight;
                inAir = true;
                
                m_animator.ResetTrigger("Idle");
                m_animator.SetTrigger("Jump");
            }
            
            /*if(Input.GetKeyUp(KeyCode.Space))
            {
                Debug.LogError("Space key released.");
                m_animator.ResetTrigger("Jump");
                m_animator.SetTrigger("Idle");
            }*/
        }
        else
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //yVelocity += jumpHeight;
                m_animator.ResetTrigger("Jump");
                m_animator.SetTrigger("Idle");
                inAir = false;
            }
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;
        _ccontrol.Move(velocity * Time.deltaTime);
        LivesLeft();
        TurnLeft();
        TurnRight();
    }

    public void AddCoins()
    {
        _coins++;
        _ui.UpdateCoinAmount(_coins);
    }

    public void LoseLife()
    {
        _lives--;
        Invoke("Respawn", 0.3f);
    }

    void LivesLeft()
    {
        _ui.UpdateLives(_lives);
    }

    

    void Respawn()
    {
        transform.position = _spawn.position;
    }

    void TurnLeft()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _frog.LookAt(left, Vector3.up);
        }
    }

    void TurnRight()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            _frog.LookAt(right, Vector3.up);
        }
    }
}
