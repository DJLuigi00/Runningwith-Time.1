using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Death : MonoBehaviour
{
    [SerializeField] private GameObject canvasObject;
    [SerializeField] private GameObject lavaDeathImage;
    [SerializeField] private PlayerControler playerControler;

    private void OnTriggerEnter(Collider other)
    {
        canvasObject.SetActive(true);
        lavaDeathImage.SetActive(true);
        playerControler.characterIsActive = false;
    }
}
