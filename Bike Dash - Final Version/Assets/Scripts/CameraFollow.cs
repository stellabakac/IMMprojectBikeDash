using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The bike
    public Vector3 offset = new Vector3(0, 5, -10); // Camera's position relative to the bike
    public float followSpeed = 10f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Smoothly follow the bike
            Vector3 desiredPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

            // Always look at the bike
            transform.LookAt(target);
        }
    }
}
