using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(
            Mathf.Clamp(target.position.x, -1.0f, 63.0f), 
            Mathf.Clamp(target.position.y, -15.0f, 58.0f),
            -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
