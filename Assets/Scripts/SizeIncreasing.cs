using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncreasing : MonoBehaviour
{
    [SerializeField] private Transform _follower;
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = (_follower.position - transform.position).normalized;
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
        transform.LookAt(_follower);
    }
}