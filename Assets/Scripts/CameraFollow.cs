using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, playerTransform.position.y + 6f, playerTransform.position.z - 8.5f);
    }
}
