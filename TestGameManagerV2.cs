using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class TestGameManagerV2 : MonoBehaviour
{
    //Create and initialize a list of gameobjects
    public List<GameObject> objectsToSpawn = new List<GameObject>();

    public List<GameObject> objectsCreated = new List<GameObject>();

    //Getter and setter to keep track of count.
    public  int spawnCount{ get; set; }

    bool _colorSpawnedItems = false;

    Material _material;

    //Spawn 3 gameobjects(prefabs already prepared in unity)
    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //If the nm of spawned objects reaches 10, do nothing and spawn no more
            if(spawnCount == 10)
            {
                _colorSpawnedItems = true;
                return;
            }

            //Select a random object from the list and store it to be instantiated.
            GameObject currentObject = objectsToSpawn[Random.Range(0, objectsToSpawn.Count)];
            //Store the clone to access its material
            GameObject go = Instantiate( currentObject, new Vector3(Random.Range(-10, 10), Random.Range(-10,10), 0), Quaternion.identity);

            objectsCreated.Add(go);
            spawnCount++;
            
            if(_colorSpawnedItems == true)
            {
                _colorSpawnedItems = false;

                foreach(GameObject ob in objectsCreated)
                {
                    _material.color = Color.green;
                }
                objectsCreated.Clear();

            }
        }
    }
}