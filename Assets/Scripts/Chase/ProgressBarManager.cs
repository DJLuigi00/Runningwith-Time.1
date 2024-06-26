using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBarManager : MonoBehaviour
{
    [SerializeField] private Image neonProgressBar;
    [SerializeField] private Image crankProgressBar;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject neon;
    [SerializeField] private float neonIncrementAmmount;

    private float timer = 7;

    private void Update()
    {
        crankProgressBar.fillAmount = player.transform.position.z / 348f;

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            timer = 0;
        }
        if (timer == 0)
        {
            timer = 1.5f;
            neonProgressBar.fillAmount += neonIncrementAmmount / 100;
            neon.SetActive(true);
        }

        if (neonProgressBar.fillAmount >+ crankProgressBar.fillAmount || crankProgressBar.fillAmount - neonProgressBar.fillAmount < 0.01)
        {
            SceneManager.LoadScene(4);
        }

        neon.transform.position = new Vector3(neon.transform.position.x, neon.transform.position.y, neonProgressBar.fillAmount * 348f);
    }
}
