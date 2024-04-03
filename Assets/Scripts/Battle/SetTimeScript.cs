using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeScript : MonoBehaviour
{
    public Battle battle;
    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        battle.playerTurnCount = gameManager.savedPlayerTurnCount;
    }
}
