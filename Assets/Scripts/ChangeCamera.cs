using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera = null;
    [SerializeField] private Camera _mapCamera = null;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _mapCamera.gameObject.SetActive(false);
            _mainCamera.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            _mapCamera.gameObject.SetActive(true);
            _mainCamera.gameObject.SetActive(false);
        }
    }
}
