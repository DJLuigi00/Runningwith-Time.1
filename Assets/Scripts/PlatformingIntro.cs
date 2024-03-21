using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlatformingIntro : MonoBehaviour
{

    private float timeLeft = 1;
    private float cycle = 1;

    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject dummy;

    void Update()
    {
        if (cycle < 6)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                Debug.Log(timeLeft);
            }

            if (timeLeft <= 0)
            {
                timeLeft = 0;
            }

            if (timeLeft == 0)
            {
                timeLeft = 1;
                cycle++;
            }


            switch (cycle)
            {
                case 1:
                    text.text = "3"; break;
                case 2:
                    text.text = "2"; break;
                case 3:
                    text.text = "1"; break;
                case 4:
                    text.text = "GO!!!"; break;
                case 5:
                    text.text = ""; player.SetActive(true); dummy.SetActive(false); break;
            }
        }
    }
    
}
