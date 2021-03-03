using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAnimator1 : MonoBehaviour
{
    Animator animator;
    public GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("Punch", true);
            vfx.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            animator.SetBool("Punch", false);
        }
    }
}
