using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableTurn : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    private void Update()
    {
        transform.eulerAngles += (Vector3.up * _speed * Time.deltaTime).normalized ; 
    }
}
