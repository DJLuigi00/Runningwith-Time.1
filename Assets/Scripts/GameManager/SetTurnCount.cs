using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTurnCount : MonoBehaviour
{
    private GameManager manager;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        manager.savedPlayerTurnCount = 500;
    }
}
