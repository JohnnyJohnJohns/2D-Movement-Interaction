using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIPatrol : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> move;
    [SerializeField] private float moveDir = 1f;
    [SerializeField] private Transform patrolLeft, patrolRight;
    [SerializeField] private bool isPatrolType;

    private void Update()
    {
        if (isPatrolType)
        {
            if (transform.position.x < patrolLeft.position.x)
            {
                moveDir = 1f;
            }

            if (transform.position.x > patrolRight.position.x)
            {
                moveDir = -1f;
            }

            move.Invoke(moveDir);
        }
    }
}
