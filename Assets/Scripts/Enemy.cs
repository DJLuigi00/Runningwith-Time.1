using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    private float hitTimer = 0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You hit me!");
        animator.SetBool("IsHitting", true);
        hitTimer = 1f;
    }

    private void Update()
    {
        hitTimer -= Time.deltaTime;
        if (hitTimer <= 0f)
        {
            hitTimer = 0f;
            animator.SetBool("IsHitting", false);
        }
    }
}
