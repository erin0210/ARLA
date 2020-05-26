using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choice : MonoBehaviour {

	public GameObject TextBox;
	public GameObject Choice1;
	public GameObject Choice2;
	public GameObject Choice3;
	public GameObject Choice4;
	public int ChoiceMade;
	public static float TotalCorrect = 0;
	public float scorePer = 0;
	public Transform ScoreObj;


	public void ChoiceOption1 () {
		TextBox.GetComponent<Text>().text="Excellent !";
		ChoiceMade = 1;
		TotalCorrect += 1;
	}
	public void ChoiceOption2 () {
		TextBox.GetComponent<Text>().text="Try again :(";
		ChoiceMade = 2;
	}
	public void ChoiceOption3 () {
		TextBox.GetComponent<Text>().text="Wrong answer ";
		ChoiceMade = 3;
	}
	public void ChoiceOption4 () {
		TextBox.GetComponent<Text>().text="Sorry but your answer is wrong";
		ChoiceMade = 4;
	}
		

	void Update(){

		if (changescene.TotalQuestion > 0) {
			scorePer = (TotalCorrect / changescene.TotalQuestion) * 100;

			ScoreObj.GetComponent<Text>().text = "Score: " + scorePer.ToString("#.##") + "%";

		}
		
		if (ChoiceMade >=1) {

			Choice1.SetActive (false);
			Choice2.SetActive (false);
			Choice3.SetActive (false);
			Choice4.SetActive (false);
		}

	} 

}
