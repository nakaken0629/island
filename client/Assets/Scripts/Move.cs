using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    private NavMeshAgent agent;

    private RaycastHit hit;
    private Ray ray;

    [SerializeField] private Animator m_animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        m_animator.SetBool("Grounded", true);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                agent.SetDestination(hit.point);
            }
        }
        if (agent.remainingDistance > 0.02f) {
            m_animator.SetFloat("MoveSpeed", 1);
        }
        else if (agent.remainingDistance < 0.001f)
        {
            m_animator.SetFloat("MoveSpeed", 0);
        }
    }
}