using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsDisplay : MonoBehaviour, IDataPersistence
{
    /*[HideInInspector]*/ public int deathCount;
    /*[HideInInspector]*/ public int winCount;

    [SerializeField] private TMP_Text deathCountTxt;
    [SerializeField] private TMP_Text winCountTxt;

    private void Update()
    {
        deathCountTxt.text = this.deathCount.ToString();
        winCountTxt.text = this.winCount.ToString();
    }

    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
        this.winCount = data.winCount;
    }
    public void SaveData(ref GameData data)
    { 
        data.deathCount = this.deathCount;
        data.winCount = this.winCount;
    }    
}
