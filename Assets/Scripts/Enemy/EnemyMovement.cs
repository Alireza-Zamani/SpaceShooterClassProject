using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.4f;
    
    [SerializeField]
    private Transform _destination;

    private void Update()
    {
        if (_destination != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _destination.position,
                speed * Time.deltaTime);
        }
    }
}
