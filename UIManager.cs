using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text _coinAmount;
   
    // Update is called once per frame
    public void UpdateCoinAmount(int numCoins)
    {
        _coinAmount.text = "Collected " + numCoins;
    }
}
