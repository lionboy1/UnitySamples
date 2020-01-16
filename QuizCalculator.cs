usng System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrades : Monobehaviour
{
	public quiz1, quiz2, quiz3, quiz4, quiz5;
	
	void Start()
	{
		quiz1 = Random.Range(0f, 100f);
		quiz2 = Random.Range(0f, 100f);
		quiz3 = Random.Range(0f, 100f);
		quiz4 = Random.Range(0f, 100f);
		quiz5 = Random.Range(0f, 100f);
		
		float average = ( quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
		average = Mathf.Round( average * 100f) /100f;
		
		Debug.Log("The average quiz score is" + average);
	}
}
