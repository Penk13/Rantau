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
            Mathf.Clamp(target.position.x, -5.0f, 67.0f), 
            Mathf.Clamp(target.position.y, -19.0f, 60.0f),
            -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
