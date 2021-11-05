using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///This isn't part of the C# Survival course
///Just my own based on what I learned
//to implement a new idea


///Count only unique characters
public class UniqueNumbers : MonoBehaviour
{
    
    //List<string> words = new List<string>();

    //List<string> uniqueLetters = new List<string>();
    Dictionary<char, int> letters = new Dictionary<char, int>();
    void Start()
    {
        letters.Add('a', 0);
        letters.Add('b', 0);
        letters.Add('c', 0);
        letters.Add('d', 0);
        letters.Add('e', 0);
        letters.Add('f', 0);
        letters.Add('g', 0);
        letters.Add('h', 0);
        letters.Add('i', 0);
        letters.Add('j', 0);
        letters.Add('k', 0);
        letters.Add('l', 0);
        letters.Add('m', 0);
        letters.Add('n', 0);
        letters.Add('o', 0);
        letters.Add('p', 0);
        letters.Add('q', 0);
        letters.Add('r', 0);
        letters.Add('s', 0);
        letters.Add('t', 0);
        letters.Add('u', 0);
        letters.Add('v', 0);
        letters.Add('w', 0);
        letters.Add('x', 0);
        letters.Add('y', 0);
        letters.Add('z', 0);
        CountUnique("yea");
        
       
    }

    // Update is called once per frame
    void CountUnique(string words)
    {
        //for(int i = 0; i < words.Length; i++)
        foreach(var key in letters.Keys)
        {
            for(int i = 0; i < words.Length; i++)
            {    
                char eachLetter = (char)words[i];
                if(letters.ContainsKey(eachLetter))
                {
                    letters.Add(eachLetter, +1);
                }
            }
        }
        foreach(KeyValuePair<char,int> all in letters)
        {
            Console.WriteLine(all.Key);
            Console.WriteLine(all.Value);
        }
       
    }

    void Update()
    {
        //
    }
}
