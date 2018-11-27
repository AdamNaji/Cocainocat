using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausee : MonoBehaviour
{
    public bool gamePause = false;

    [SerializeField] private GameObject pauseMenuUI;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (gamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;  
        gamePause = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        gamePause = true;
                

    }
    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

