using System.Collections;
using System.Collections.Generic;
using FishNet.Object;
using UnityEngine;

public class Animation : NetworkBehaviour
{
    Animator animator;

    public override void OnStartClient()
    {
        base.OnStartClient();
        if (base.IsOwner) {
            
        } else {
            gameObject.GetComponent<Animation>().enabled = false;
        }
    }

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }
}
