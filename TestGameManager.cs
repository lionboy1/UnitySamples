using UnityEngine;
using System.Collections.Generic;
using System.Collections;


///Create a list of names
//Print out all names

//Randomly remove a name form the list
///when space bar is pressed and reprint the names list

public class TestGameManager : MonoBehaviour
{
    public List<string> people = new List<string>();
    void Start()
    {
        people.Add("One");
        people.Add("Two");
        people.Add("Three");
        people.Add("Four");
        people.Add("Five");
        
        foreach( var person in people)
        {
            print(person);
        }
    }
    //Randomly remove a name from the list on input
    void Update()
    {
        {
            if(Input.GetKey(KeyCode.Space))
            {
                //Similar syntax to array here to access list items
                //In array use Length, but in Lists use Count.  They both do the same
                people.Remove(people[Random.Range(0, people.Count)]);
            }
        }
      
    }

}

