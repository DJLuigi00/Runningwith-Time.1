using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    public bool isActive = false;

    private void Update()
    {
        if (isActive)
        {
            transform.position = new Vector3(transform.position.x, playerTransform.position.y + 6f, playerTransform.position.z - 8.5f);
        }
    }
}
