using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followingObject;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - followingObject.transform.position;
    }

    
    private void FixedUpdate()
    {
        transform.position = followingObject.transform.position + offset;
    }
}
