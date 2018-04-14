using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeMove : Move {
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                agent.SetDestination(hit.point);
            }
        }
        UpdateMove();
    }
}
