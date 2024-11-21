using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFace : MonoBehaviour
{
    [SerializeField] private Transform _follower;
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = (_follower.position - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime);
        transform.LookAt(_follower);
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}