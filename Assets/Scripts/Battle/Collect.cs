using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public Battle battle;

    public void PressCollect()
    {
        if (battle.TntOnFeild)
        {
            battle.Tnt = true;
            battle.TntOnFeild = false;
            battle.TNT.SetActive(false);
        }
        if (battle.axeOnFeild)
        {
            battle.axe = true;
            battle.axeOnFeild = false;
            battle.AXE.SetActive(false);
        }
        if (battle.oilOnFeild)
        {
            battle.oilPressed = true;
            battle.oilOnFeild = false;
            battle.OIL.SetActive(false);
        }
        if (battle.armorOnFeild)
        {
            battle.armor = true;
            battle.armorOnFeild = false;
            battle.ARMOR.SetActive(false);
        }
        
    }
}
