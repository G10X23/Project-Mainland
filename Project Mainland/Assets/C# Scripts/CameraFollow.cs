using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    [Range(0.01f, 1f)]
    [SerializeField] private float smoothFactor = 0.5f;
    [SerializeField] private Vector3 offset;
    
    void FixedUpdate() 
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothFactor);
        transform.position = smoothedPosition;

        
    }
    
}