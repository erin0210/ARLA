using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleRenderer : MonoBehaviour {

	public GameObject obj1;
	public static bool disabled = true;

	public void ToggleVisibility()
	{
		if (disabled)
		{
			obj1.SetActive(true);
		}

		else
			obj1.SetActive(false);
	}
		
}
