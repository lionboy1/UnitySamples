using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSpawn : MonoBehaviour
{
    //Idea borrowed from https://www.youtube.com/watch?v=pmTcpCLRkCs "How to instantiate a RANDOM OBJECT in Unity" 
    [SerializeField] GameObject[] _bugs;
    [SerializeField] Transform[] _spawnPoints;
    int _spawns;
    GameObject choice;
    void Start()
    {
        //Flexible way to cache the number of GOs to be spawn.  
        //int _spawns = Random.Range(1, _bugs.Length);
        
        for(int j = 0; j < _spawnPoints.Length; j++)
        {
            int _spawns = Random.Range(0, _bugs.Length);
            choice = _bugs[_spawns];
            GameObject bugRef = Instantiate(choice, _spawnPoints[j].position, Quaternion.identity);
            /*
            for(int i = 0; i < 2; i++)
            {
            
                choice = _spawns[]
                GameObject bugRef = Instantiate(_bugs[i], _spawnPoints[j].position, Quaternion.identity);
                Debug.Log("Spawning at " + _spawnPoints[j].name);
            }
            */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
