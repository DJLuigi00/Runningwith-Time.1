using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeathCutsceneManager : MonoBehaviour
{
    [SerializeField] private GameObject countDownManager;
    [SerializeField] private CameraFollow cameraFollow;
    [SerializeField] private Animator anim;

    private float timer = 13;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timer = 0;
        }
        if(timer == 0)
        {
            countDownManager.SetActive(true);
            Destroy(anim);
            cameraFollow.isActive = true;
        }
    }
}
