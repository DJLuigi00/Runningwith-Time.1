using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableStartSplash : MonoBehaviour
{
    public GameManager manager;
    public GameObject startSplash;

    private void Awake()
    {
      manager = FindObjectOfType<GameManager>();
      
        if (manager.playStartGSScreen)
        {
            manager.playStartGSScreen = false;
        }
        else if (!manager.playStartGSScreen)
        {
            startSplash.SetActive(false);
        }
    }
}
