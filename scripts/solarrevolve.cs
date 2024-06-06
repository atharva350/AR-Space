using UnityEngine;

public class solarrevolve : MonoBehaviour
{
    // Parameters of the orbit
    public Transform centralModel;
    public float radiusX = 2f; // Radius along the x-axis
    public float radiusY = 1f; // Radius along the y-axis
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
        float x = centralModel.position.x + radiusX * Mathf.Cos(angle);
        float y = centralModel.position.y;
        float z = centralModel.position.z + radiusY * Mathf.Sin(angle); // Using radiusY for the y-axis

        // Set the position of the orbiting model
        transform.position = new Vector3(x, y, z);
    }
}
