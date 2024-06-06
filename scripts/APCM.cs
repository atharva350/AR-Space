using UnityEngine;

public class APCM : MonoBehaviour
{
    public Transform centralModel;
    public float radius = 2f;
    public float speed = 2f;
    public float heightAboveCentralModel = 1f; // Height above the central model

    private float angle = 0f;

    void Update()
    {
        // Increment the angle based on speed
        angle += speed * Time.deltaTime;

        // Calculate the position of the orbiting model relative to the central model
        float x = centralModel.position.x + radius * Mathf.Cos(angle);
        float y = centralModel.position.y + heightAboveCentralModel; // Add the height above the central model
        float z = centralModel.position.z + radius * Mathf.Sin(angle);

        // Set the position of the orbiting model
        transform.position = new Vector3(x, y, z);
    }
}
