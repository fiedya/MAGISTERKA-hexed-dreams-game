using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public float cooldownTime;
    float nextFireTime = 0;
    public static int noOfClicks = 0;
    float lastClickedTime = 0;
    float maxComboDelay = 1;
    string attack_swing_activator = "sword_swing";


    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ciach");
            animator.SetTrigger(attack_swing_activator);
        }
    }

    void OnClick()
    {

    }
}
