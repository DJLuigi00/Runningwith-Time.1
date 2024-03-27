using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private int sceneID;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneID);
    }
}
