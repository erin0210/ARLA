using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dictionary : MonoBehaviour {
    
    public void GotoBookScene()
    {
        SceneManager.LoadScene("book");
    }
}
