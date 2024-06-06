using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VikramPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the center of the screen in world space
        Vector3 screenCenter = new Vector3(Screen.width / 2 - 150, Screen.height / 2 - 200, 10); // 10 units away from the camera (adjust as necessary)

        // Convert the screen center to world space
        Vector3 worldCenter = Camera.main.ScreenToWorldPoint(screenCenter);

        // Set the model's position to the world center
        transform.position = worldCenter;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the center of the screen in world space
        Vector3 screenCenter = new Vector3(Screen.width / 2 - 150, Screen.height / 2 - 200, 10); // 10 units away from the camera (adjust as necessary)

        // Convert the screen center to world space
        Vector3 worldCenter = Camera.main.ScreenToWorldPoint(screenCenter);

        // Set the model's position to the world center
        transform.position = worldCenter;
        
    }
}
