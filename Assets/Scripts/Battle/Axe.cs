using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

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
                battle.PlayerTurn = false;
                Debug.Log("Enemy Health =" + battle.enemyTurnCount);
                Debug.Log("Axe =" + battle.axe);
            }
        }
    }
}
