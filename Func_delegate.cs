using System;
using System.Collections.Generic;
using UnityEngine;

//Func is a newer delegate which has a return type, unlike the Action delegate which is void
public class Func_delegate : MonoBehaviour
{
    ///Reads as follows:
    ///public int letter_check(string someStringInput)
    public Func<string, int> letter_check;

    void Start()
    {
        letter_check = CharacterCount;
        int werds = letter_check("Oh Laowd");
        Debug.Log("Count :" + werds);
    }

    int CharacterCount(string name)
    {
        return name.Length;
    }
}
