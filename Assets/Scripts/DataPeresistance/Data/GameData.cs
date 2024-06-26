using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    // values defined in constructor will be default values
    // game starts with these default values when there's no data to load

    public int deathCount;
    public int winCount;

    public GameData()
    {
        this.deathCount = 0;
        this.winCount = 0;
    }
}
