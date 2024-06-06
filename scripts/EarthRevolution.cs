using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRevolve : MonoBehaviour
{

    // Parameters of the orbit
    public Transform centralModel;
    public float radius = 2f;
    public float speed = 2f;

    // Current angle of rotation
    private float angle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the angle based on speed
        angle += speed * Time.deltaTime;

        // Calculate the position of the orbiting model relative to the central model
        float x = centralModel.position.x + radius * Mathf.Cos(angle);
        float y = centralModel.position.y;
        float z = centralModel.position.z + radius * Mathf.Sin(angle);

        // Set the position of the orbiting model
        transform.position = new Vector3(x, y, z);
    }
}
