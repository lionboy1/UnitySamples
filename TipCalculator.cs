usng System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : Monobehaviour
{
	//Bill is $40
	//Tis based on 20%
	//Calculate otal amount
	int bill = 40;
	float tipAmount = 20.0f;
	float total;


	void Start()
	{
		tip = bill * (tip/100);
		total = bill + tip;
		
		Debug.Log("The bill is" + bill + "and the tip should be" + tip + "so total owed is" + total);
	}
}
