using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescene : MonoBehaviour {

	public static int TotalQuestion = 1;


	public void changemenuscene (string scenename)
	{
		Application.LoadLevel (scenename);
		TotalQuestion += 1;
	}
		
}
