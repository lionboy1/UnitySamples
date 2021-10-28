using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text _coinAmount, _lives;
   
    // Update is called once per frame
    public void UpdateCoinAmount(int numCoins)
    {
        _coinAmount.text = "Collected " + numCoins.ToString();
    }

    public void UpdateLives(int life)
    {
        _lives.text = "Life: " + life.ToString();
    }
}
