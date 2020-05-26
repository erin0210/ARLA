using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTwice : MonoBehaviour {

	public GameObject obj1;

	public void ToggleVisibility()
	{
		if (obj1.GetComponent<Image>().enabled == true )
		{
			obj1.SetActive(false);
		}

		else
			obj1.SetActive(true);
	}

}
