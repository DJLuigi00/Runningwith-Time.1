using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    public Battle battle;
    public Animator animator;

    public void PressTNT()
    {
        if (battle.PlayerTurn == true)
        {
            if (battle.Tnt == true) 
            {
                battle.playerDamage = 250;
                animator.SetTrigger("DoExplosion");
                battle.enemyTurnCount -= battle.playerDamage;
                battle.Tnt = false;
                if (battle.oil == true)
                {
                    battle.oil = false;
                }
                else { battle.PlayerTurn = false; }
                Debug.Log("TNT =" + battle.Tnt);
                Debug.Log("Enemy Hp =" + battle.enemyTurnCount);
            }
        }
    }
}
