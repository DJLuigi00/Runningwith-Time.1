using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        bool audioActive = true;

        if(currentScene == 6 || currentScene == 1)
        {
            audioActive = true;
        }
        else
        {
            audioActive = false;
        }

        if(!audioActive) 
        { 
            Destroy(this.gameObject); 
        }
    }
}
