using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class display : MonoBehaviour {

	public Text t1, t2, t3, t4;
	public InputField I1, I2, I3, I4;
	// Use this for initialization
	void Start () {
		t1 = GetComponent<Text> ();
		t1.text = I1.text;

		t2 = GetComponent<Text> ();
		t2.text = I2.text;

		t3 = GetComponent<Text> ();
		t3.text = I3.text;

		t4 = GetComponent<Text> ();
		t4.text = I4.text;


	}
	
	public void ShowText(){
		t1.text = I1.text;
		t2.text = I2.text;
		t3.text = I3.text;
		t4.text = I4.text;

	}
}
