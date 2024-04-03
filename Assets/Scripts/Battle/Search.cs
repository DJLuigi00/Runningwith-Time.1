using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search : MonoBehaviour
{
    public int randomSearch;
    public Battle battle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressSearch()
    {
        if (battle.PlayerTurn == true)
        {
            randomSearch = Random.Range(1, 11);
            
            switch (randomSearch)
            {
                case 1:
                    battle.TntOnFeild = true;
                    battle.TNT.SetActive(true);
                    Debug.Log("TNT =" + battle.Tnt);
                    break;
                case 2:
                    battle.oilOnFeild = true;
                    battle.OIL.SetActive(true);
                    Debug.Log("oil =" + battle.oil);
                    break;
                case 3:
                    battle.axeOnFeild = true;
                    battle.AXE.SetActive(true);
                    Debug.Log("Axe =" + battle.axe);
                    break;
                case 4:
                    battle.armorOnFeild = true;
                    battle.ARMOR.SetActive(true);
                    Debug.Log("Armor =" + battle.armor);
                    break;
                case 5:
                    battle.oilOnFeild = true;
                    battle.OIL.SetActive(true);
                    Debug.Log("oil =" + battle.oil);
                    break;
                case 6:
                    battle.oilOnFeild = true;
                    battle.OIL.SetActive(true);
                    Debug.Log("oil =" + battle.oil);
                    break;
                case 7:
                    battle.axeOnFeild = true;
                    battle.AXE.SetActive(true);
                    Debug.Log("Axe =" + battle.axe);
                    break;
                case 8:
                    battle.axeOnFeild = true;
                    battle.AXE.SetActive(true);
                    Debug.Log("Axe =" + battle.axe);
                    break;
                case 9:
                    battle.armorOnFeild = true;
                    battle.ARMOR.SetActive(true);
                    Debug.Log("Armor =" + battle.armor);
                    break;
                case 10:
                    battle.axeOnFeild = true;
                    battle.AXE.SetActive(true);
                    Debug.Log("Axe =" + battle.axe);
                    break;
            }
            if (battle.oil == true)
            {
                battle.oil = false;
            }
            else { battle.PlayerTurn = false; }
        }
    }
}
