using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    public Battle battle;

    public void PressOil()
    {
        if (battle.oilPressed == true)
        {
            battle.oil = true;
            battle.oilPressed = false;
            Debug.Log("Oil = " +  battle.oil);
            Debug.Log("OilPressed = " + battle.oilPressed);
        }
    }
}
