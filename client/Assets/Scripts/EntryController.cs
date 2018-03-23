using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        Debug.Log("start");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
            animator.SetInteger("mode", 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            animator.SetInteger("mode", 0);
        }
    }
}
