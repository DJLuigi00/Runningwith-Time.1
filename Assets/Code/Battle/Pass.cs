using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    public Battle battle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressPass()
    {
        if (battle.PlayerTurn == true)
        {
            if (battle.oil == true)
            {
                battle.oil = false;
            }
            else { battle.PlayerTurn = false; }
        }
    }
}
