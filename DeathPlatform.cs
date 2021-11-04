using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatform : MonoBehaviour
{
    Player _player;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        if(_player == null)
        {
            Debug.Log("No Player component found!");
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _player.LoseLife();
            other.transform.position = _player._spawnPoint.position;
            if(_player.CanPlay())
            {
                _player.EnableCC();
            }
            else
            {
                other.transform.position = _player._spawnPoint.position;
                other.transform.parent = null;
            }
            
        }
    }
}
