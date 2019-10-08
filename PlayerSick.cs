using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSick : Monobehaviour
{
	private void Start()
	{
		for( int i = 0; i < 100; i++ )
		{
			Debug.Log(i);
			if ( i < 5 )
			{
				break;
			}	
		}
		
		Debug.Log( "Player is severely ill" )
	}
	
	private void Update(){}
	
}


