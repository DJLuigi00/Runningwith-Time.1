using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused = false;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            isPaused = true;
        }
        if (isPaused) 
        { 
            Time.timeScale = 0f;
        }
    }
    public void UnPaused()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }
    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }
}
