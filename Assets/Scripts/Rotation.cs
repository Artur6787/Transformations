using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Debug.Log("Current Rotation: " + transform.rotation.eulerAngles);
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}