using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, playerTransform.position.y + 3.42f, playerTransform.position.z - 7.8f);
    }
}
