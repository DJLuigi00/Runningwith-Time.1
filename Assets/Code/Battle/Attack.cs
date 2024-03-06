using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    public Battle battle;
    public GameObject hitbox;
    public float hitTimer = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hitTimer > 0)
        {
            hitTimer -= Time.deltaTime;
        }
        else
            hitbox.SetActive(false);
    }

    public void PressAttack()
    {
        if (battle.PlayerTurn == true)
        {
            battle.playerDamage = battle.playerLevel + Random.Range(1, 10);
            battle.enemyTurnCount = battle.enemyTurnCount - battle.playerDamage;
            animator.SetTrigger("DoHit");

            hitTimer = 1f;
            hitbox.SetActive(true);

            Debug.Log("Enemy HP = " + battle.enemyTurnCount);
            if (battle.oil == true) 
            {
                battle.oil = false;
            }
            else 
            {
                battle.PlayerTurn = false;
            } 
        }
    }

    public void BattleAttack(Battle attackingThing)
    {
                  
      
    }
}
