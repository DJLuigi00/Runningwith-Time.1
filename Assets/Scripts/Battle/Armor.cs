using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    public Battle battle;

    public void PressArmor()
    {
        if (battle.armor == true)
        {
            battle.armor = false;
            battle.playerTurnCount += 150;
            Debug.Log("Player HP = " + battle.playerTurnCount);
            if (battle.oil == true)
            {
                battle.oil = false;
            }
            else { battle.PlayerTurn = false; }
        }
    }
}
