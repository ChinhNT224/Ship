using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    void Update()
    {
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;


        var screenWidth = Screen.width;
        var screenHeight = Screen.height;

        var screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(screenWidth, screenHeight, 0));


        var clampedPosition = new Vector3(
            Mathf.Clamp(worldPoint.x, -screenBounds.x, screenBounds.x),
            Mathf.Clamp(worldPoint.y, -screenBounds.y, screenBounds.y),
            0
        );

        transform.position = clampedPosition;

        Debug.Log(Input.mousePosition);
        Debug.Log("World point: " + worldPoint);
    } 
}
