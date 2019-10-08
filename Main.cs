//CLick listener which will allow the color /texture change of one prefab.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : Monobehaviour
{
	public delegate void ActionClick();
	public static event ActionClick onClick;
	
	public void ButtonClick()
	{
		if(onClick != null)
		{
			onClick();
		}
	}
}
