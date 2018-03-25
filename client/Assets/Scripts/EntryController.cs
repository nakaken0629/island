using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void MoveToCharacter()
    {
        animator.SetInteger("mode", 1);
    }

    public void MoveToName()
    {
        animator.SetInteger("mode", 0);
    }
}
