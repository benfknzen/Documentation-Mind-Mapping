using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanAndZoom : MonoBehaviour
{
    Vector3 touchStart;
    public float zoomOutMin;
    public float zoomOutMax;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            if(touchZero.deltaPosition.magnitude > 1)
            {
                //Handles Zooming in and out
                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                zoom(difference * 0.005f);

                ////Handles Rotating around X and Y axis only
                Vector3 axis;

                axis = new Vector3(-touchZero.position.x + touchOne.position.x, -touchZero.position.y + touchOne.position.y, 0);

                rotateAxis(axis * 0.0005f);
            }



        }
        else if (Input.GetMouseButton(0))
        {
            //Panning
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
            
        }
        zoom(Input.GetAxis("Mouse ScrollWheel"));
    }
    private void rotateAxis(Vector3 axis)
    {
        Camera.main.transform.Rotate(axis);
    }

    void zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}