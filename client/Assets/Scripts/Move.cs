using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public abstract class Move : MonoBehaviour
{
    protected NavMeshAgent agent;

    [SerializeField] protected Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator.SetBool("Grounded", true);
    }

    protected virtual void UpdateMove()
    {
        if (agent.remainingDistance > 0.04f) {
            animator.SetFloat("MoveSpeed", 1);
        }
        else if (agent.remainingDistance < 0.02f)
        {
            animator.SetFloat("MoveSpeed", 0);
        }
    }
}