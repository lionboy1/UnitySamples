using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestItemDB : MonoBehaviour
{
    //Create a list, referencing the Item class because dictionaries can't show in inspector but lists can
    //manually populate the list name sin inspector
    public List<Item> itemList = new List<Item>();

    //Using the list above, populate the dictoinary with it's content.
    //Dictionaries ar eused to store and retrieve data, but are not serializable in Unity's inspector
    public Dictionary<int, Item> dictionaryItems = new Dictionary<int, Item>();

    //Add the list items to dictionary

    void Start()
    {
        //Initialize the sword as an item first
        //The Item class requires a name and id
        
        Item sword = new Item();
        sword.name = "Swoad";
        sword.id = 0;

        Item bow = new Item();
        bow.name = "Boe";
        bow.id = 1;

        //itemList.Add(sword);
        //itemList.Add(bow);

        foreach(var item in itemList)
        {
            Debug.Log("Item in list " + item.name);
        }
        //the value of the sword contains all of the information

        /*dictionaryItems.Add(0, sword);
        dictionaryItems.Add(1, bow);

        foreach(KeyValuePair<int, Item> item in dictionaryItems)
        {
            Debug.Log("item is " + item.Value.name);
            Debug.Log("item is " + item.Key);
        }*/

        foreach(int key in dictionaryItems.Keys)
        {
            //Iterate through keys only
        }

        foreach(Item value in dictionaryItems.Values)
        {
            //iterate values
        }
    }
    

}