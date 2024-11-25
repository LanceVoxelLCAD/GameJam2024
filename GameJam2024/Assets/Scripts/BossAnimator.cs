using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimator : MonoBehaviour
{
    public Animator animator;
    public bool isAttacking;
    public GameObject attackGroup;
    private float nextShotTime;
    public float attackTime = 4f;

    private void Start()
    {
        isAttacking = animator.GetBool("isAttacking");
        isAttacking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAttacking && Time.time > nextShotTime)
        {
            animator.SetBool("isAttacking", true);
            isAttacking = true;
            attackGroup.SetActive(true);
            nextShotTime = Time.time + attackTime;
            //set timer for attack
        }
        else if (isAttacking && Time.time > nextShotTime)
        {
            animator.SetBool("isAttacking", false);
            isAttacking = false;
            attackGroup.SetActive(false);
            nextShotTime = Time.time + attackTime;
            //turn on empty
        }
    }
}
