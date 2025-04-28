using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera _camera;

    public Transform cameraPosition;


    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
