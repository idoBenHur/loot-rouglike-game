using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class light_increase : MonoBehaviour
{
    private float decreaseRate = 5f; // Rate at which spotAngle decreases
    private float increaseRate = 90f; // Rate at which spotAngle increases
    public Light spotlight;

    void Start()
    {
        
    }

    void Update()
    {
        // Decrease the spotAngle over time
        float newSpotAngle = Mathf.Max(0f, spotlight.spotAngle - decreaseRate * Time.deltaTime);
        spotlight.spotAngle = newSpotAngle;

        // Increase the spotAngle when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float increasedSpotAngle = Mathf.Min(180f, spotlight.spotAngle + increaseRate);
            spotlight.spotAngle = increasedSpotAngle;
        }
    }
}
