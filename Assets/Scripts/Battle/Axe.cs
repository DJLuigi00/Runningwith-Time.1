using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public Battle battle;
    public Animator animator;
    public void PressAxe()
    {
        if (battle.PlayerTurn == true)
        {
            if (battle.axe == true)
            {
                battle.playerDamage = 50;
                animator.SetTrigger("DoSlash");
                battle.enemyTurnCount -= battle.playerDamage;
                battle.axe = false;
                if (battle.oil == true)
                {
                    battle.oil = false;
                }
                else
                {
                    battle.PlayerTurn = false;
                }
                Debug.Log("Enemy Health =" + battle.enemyTurnCount);
                Debug.Log("Axe =" + battle.axe);
            }
        }
    }
}
