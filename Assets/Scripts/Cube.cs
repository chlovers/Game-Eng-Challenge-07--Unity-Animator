using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Animator animator;
    bool spin;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        spin = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            if (spin == false)
            {
                animator.SetBool("spin", true);
                spin = true;
                Debug.Log("spin started");
            }

             else if (spin==true)
            {
                animator.SetBool("spin", false);
                spin = false;
                Debug.Log("spin stoped");
            }
        }




    }
}
