using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : Move {
	void Update () {
        if (!agent.hasPath) 
        {
            var target = new Vector3((Random.value - 0.5f) * 15, 0.5f, (Random.value - 0.5f) * 15);
            agent.SetDestination(target);
        }
        UpdateMove();
	}
}
