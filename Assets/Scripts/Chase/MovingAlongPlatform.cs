using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAlongPlatform : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.parent = transform;
    }

    private void OnCollisionExit(Collision collision)
    {
        player.transform.parent = null;
    }
}
