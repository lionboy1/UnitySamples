using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform _point_A, _point_B;
    [SerializeField] float _speed;
    bool _switch = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        //transform.position = Vector3.MoveTowards(transform.position, _point_A.position, _speed * Time.deltaTime );
        if(transform.position == _point_A.position)
        {
            _switch = true;
        }
        else if(transform.position == _point_B.position)
        {
             _switch = false;
        }
        if(_switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _point_B.position, _speed * Time.deltaTime );
        }
        if(_switch == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _point_A.position, _speed * Time.deltaTime );
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = this.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = null;
        }
    }

    
}
