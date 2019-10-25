using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{   // Frame update example: Draws a 10 meter long green line from the position for 1 frame.
    void FixedUpdate()
    {
        Vector3 DimensionX = transform.TransformDirection(new Vector3(1, 0, 0)) * 10;
        Vector3 DimensionY = transform.TransformDirection(new Vector3(0, 1, 0)) * 10;
        Vector3 DimensionZ = transform.TransformDirection(new Vector3(0, 0, 1)) * 10;
        Debug.DrawRay(transform.position, DimensionX, Color.red);
        Debug.DrawRay(transform.position, DimensionY, Color.green);
        Debug.DrawRay(transform.position, DimensionZ, Color.blue);
        Debug.DrawRay(transform.position, -1 * DimensionX, Color.red);
        Debug.DrawRay(transform.position, -1 * DimensionY, Color.green);
        Debug.DrawRay(transform.position, -1 * DimensionZ, Color.blue);
    }
}