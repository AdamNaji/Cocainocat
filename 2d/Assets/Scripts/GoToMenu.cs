using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
    public void  LoadGame()
    {
        SceneManager.LoadScene("game");
    }
}
