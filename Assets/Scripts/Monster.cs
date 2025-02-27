using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    Animator animator;
    float movement = 0f;
    float sped = 0.2f;


    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
  float spiny = Input.mouseScrollDelta.y;
        movement += spiny * sped;
 movement = Mathf.Round(movement*10) / 10f;
         movement = Mathf.Clamp(movement, 0f, 1f);
        animator.SetFloat("Run", movement);
    }
}
