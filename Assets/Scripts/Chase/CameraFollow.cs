using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    public bool isActive = false;

    private void Update()
    {
        if (isActive)
        {
            if(Input.GetKey(KeyCode.E)) 
            {
                transform.position = new Vector3(transform.position.x, playerTransform.position.y + 6f, playerTransform.position.z + 8.5f);
                transform.localRotation = Quaternion.Euler(16, 180, 0);
            }
            else 
            { 
                transform.position = new Vector3(transform.position.x, playerTransform.position.y + 6f, playerTransform.position.z - 8.5f);
                transform.localRotation = Quaternion.Euler(16, 0, 0);
            }

        }
    }
}
