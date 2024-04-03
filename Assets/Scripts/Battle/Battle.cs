using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject Enm_HP;
    public GameObject TimeLeft;
    public GameObject AXE;
    public GameObject OIL;
    public GameObject ARMOR;
    public GameObject TNT;
    public GameObject Hit1;
    public GameObject Hit2;
    public GameObject Hit3;
    public GameObject Oil_Button;
    public GameObject Tnt_Button;
    public GameObject Axe_Button;
    public GameObject Armor_Button;
    public GameObject CongratsScreen;
    public GameObject DefaultUI;
    public GameManager manager;

    public GameObject[] Hit = new GameObject[3];

    [Header("TMP")]
    [SerializeField] TextMeshProUGUI HPText;
    [SerializeField] public TMP_Text inventoryOilTxt;
    [SerializeField] public TMP_Text inventoryTntTxt;
    [SerializeField] public TMP_Text inventoryArmorTxt;
    [SerializeField] public TMP_Text inventoryAxeTxt;
    [SerializeField] public TMP_Text winTime;

    [Header("Ints/floats")]
    public float playerTurnCount;


    public float HitTime = 1.5f;
    public float DefaultHitTime = 1.5f;
    public int unitLevel;
    public int enemyTurnCount;
    public int enemyDamage;
    public int playerDamage;

    public int playerLevel;

    [Header("Bools")]
    public bool PlayerTurn;
    public bool Tnt;
    public bool TntOnFeild;
    public bool oil;
    public bool oilOnFeild;
    public bool oilPressed;
    public bool axe;
    public bool axeOnFeild;
    public bool armor;
    public bool armorOnFeild;
    public bool BattleOver;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        PlayerTurn = true;
        AXE.SetActive(false);
        OIL.SetActive(false);
        ARMOR.SetActive(false);
        TNT.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!BattleOver)
        {
            Timer();
        }

        if (enemyTurnCount < 0)
        {
            enemyTurnCount = 0;
        }
        if (enemyTurnCount == 0)
        {
            CongratsScreen.SetActive(true);
            DefaultUI.SetActive(false);
            manager.savedPlayerTurnCount = playerTurnCount;
        }

        if (!PlayerTurn) 
        {
            enemyDamage = unitLevel + Random.Range(1, 12);
            playerTurnCount = playerTurnCount - enemyDamage;
            PlayerTurn = true;
            Debug.Log("Player HP = " +  playerTurnCount);
            Oil_Button.SetActive(false);
            Axe_Button.SetActive(false);
            Armor_Button.SetActive(false);
            Tnt_Button.SetActive(false);
        }
        else
        {
            Oil_Button.SetActive(true);
            Axe_Button.SetActive(true);
            Armor_Button.SetActive(true);
            Tnt_Button.SetActive(true);
        }


        // grabing the stuff off the feild
        if (TntOnFeild)
        {
            TNT.SetActive(true);
        }
        if (TntOnFeild == false)
        {
            TNT.SetActive(false);
        }
        if (axeOnFeild)
        {
            AXE.SetActive(true);
        }
        if (axeOnFeild == false)
        {
            AXE.SetActive(false);
        }
        if (armorOnFeild)
        {
            ARMOR.SetActive(true);
        }
        if (armorOnFeild == false) 
        {
            ARMOR.SetActive(false);
        }
        if (oilOnFeild)
        {
            OIL.SetActive(true);
        }
        if(oilOnFeild == false) 
        {
            OIL.SetActive(false);
        }
        //End of battle
        if (enemyTurnCount <= 0)
        {
            BattleOver = true;

        }

        Enm_HP.GetComponent<TextMeshProUGUI>().SetText(enemyTurnCount.ToString());

        if(oilPressed)
        {
            inventoryOilTxt.text = "1/1";
        }
        if (axe)
        {
            inventoryAxeTxt.text = "1/1";
        }
        if (armor) 
        {
            inventoryArmorTxt.text = "1/1";
        }
        if(Tnt)
        {
            inventoryTntTxt.text = "1/1";
        }
        if (!oilPressed)
        {
            inventoryOilTxt.text = "0/1";
        }
        if (!axe)
        {
            inventoryAxeTxt.text = "0/1";
        }
        if (!armor)
        {
            inventoryArmorTxt.text = "0/1";
        }
        if (!Tnt)
        {
            inventoryTntTxt.text = "0/1";
        }
    }

    void Timer()
    {
        {
            playerTurnCount -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(playerTurnCount / 60);
            int seconds = Mathf.FloorToInt(playerTurnCount % 60);
            HPText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
