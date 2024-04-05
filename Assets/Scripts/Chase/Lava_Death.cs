using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava_Death : MonoBehaviour
{
    /*[SerializeField] private GameObject canvasObject;
    [SerializeField] private GameObject lavaDeathImage;
    [SerializeField] private PlayerControler playerControler;*/
    [SerializeField] private int sceneID;

    private void OnTriggerEnter(Collider other)
    {
        /*canvasObject.SetActive(true);
        lavaDeathImage.SetActive(true);
        playerControler.characterIsActive = false;*/

        SceneManager.LoadScene(sceneID);
    }
}
