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
        
        if (!(transform.position.z > 950 && transform.position.z < 1100))
        {
            float zPosition = offset.z + followingObject.transform.position.z;
            transform.position = new Vector3(transform.position.x, transform.position.y, zPosition);
            
        } else
        {
            transform.position = followingObject.transform.position + new Vector3(0, 1.83f, 0);
        }
    }
}
