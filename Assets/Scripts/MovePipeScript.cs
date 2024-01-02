using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.65f;
    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
    }
}
