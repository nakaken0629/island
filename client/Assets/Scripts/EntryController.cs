using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
