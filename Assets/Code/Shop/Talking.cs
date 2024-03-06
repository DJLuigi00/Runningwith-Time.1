using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talking : MonoBehaviour
{
    
    public Animator animator;
    public Battle battle;
    public GameObject NPCText;

    void Start()
    {
        NPCText.GetComponent<TextMeshProUGUI>().SetText("Hi Welcome to the Shop I am MR Lime But you can call me L");
        //animator.SetTrigger("IsTalking");
        animator.SetBool("IsTalking", true);
    }
    public void IsTalking()
    {
        animator.SetBool("IsTalking", true);
        NPCText.GetComponent<TextMeshProUGUI>().SetText("Anything you see is for sale (not me tho)");
    }
    public void OilForSale()
    {
        battle.oil = true;
    }
    public void AxeForSale()
    {
        battle.axe = true;
    }
    public void TntForSale()
    {
        battle.Tnt = true;
    }

    void Update()
    {
        if (animator.GetBool("IsTalking") && animator.GetCurrentAnimatorStateInfo(0).IsName("Talking"))
            animator.SetBool("IsTalking", false);
    }
}
