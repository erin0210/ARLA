using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour {

	[SerializeField]
	private InputField Username;
	[SerializeField]
	private InputField Password;

	public void CheckLoginInfo()
	{
		string username = Username.text.Trim().ToLower();
		string password = Password.text;

		if (username=="student"&&password=="smktamanu123"){
			SceneManager.LoadScene("StartMenu");
		}

		else if (username=="teacher"&&password=="teacher123"){
			SceneManager.LoadScene("StartMenuTeacher");
		}

		else if (username==""||password=="")
		{
			Debug.Log("something was not filed out");
		}

		else if (username != "student" && password != "smktamanu123") 
		{
			Debug.Log("The username or/and password is wrong");
		}
			

	


	}
}
