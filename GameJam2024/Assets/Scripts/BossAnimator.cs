using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimator : MonoBehaviour
{
    public Animator animator;
    public bool isAttacking;

    private void Start()
    {
        isAttacking = animator.GetBool("isAttacking");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isAttacking)
        {
            animator.SetBool("isAttacking", true);
            isAttacking = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && isAttacking)
        {
            animator.SetBool("isAttacking", false);
            isAttacking = false;
        }
    }
}
