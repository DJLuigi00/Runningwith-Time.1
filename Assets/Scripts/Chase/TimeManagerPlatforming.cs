using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeManagerPlatforming : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private GameManager manager;
    [SerializeField] private float timer;
    private float delay;

    private void Start()
    {
        delay = 17;
        manager = FindObjectOfType<GameManager>();
        timer = manager.savedPlayerTurnCount;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
    private void Update()
    {
        if(delay > 0)
        { 
            delay -= Time.deltaTime; 
        }
        if (delay <= 0) 
        { 
            delay = 0;
        }
        if (delay ==  0) 
        {
            Timer();
        }
    }

    private void Timer()
    {
        timer -= Time.deltaTime;
        manager.savedPlayerTurnCount = timer;

        if(timer <= 0)
        {
            SceneManager.LoadScene(4);
        }

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
