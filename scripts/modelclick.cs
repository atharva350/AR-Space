using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    // Check if the clicked object has a specific tag
                    if (hit.collider.CompareTag("sun"))
                    {
                        SceneManager.LoadScene("Sun");
                    }
                    else if (hit.collider.CompareTag("mercury"))
                    {
                        SceneManager.LoadScene("Mercury");
                    }
                    // Add more else if conditions for other models as needed
                    else if (hit.collider.CompareTag("venus"))
                    {
                        SceneManager.LoadScene("Venus");
                    }
                    else if (hit.collider.CompareTag("earth"))
                    {
                        SceneManager.LoadScene("Earth");
                    }
                    else if (hit.collider.CompareTag("mars"))
                    {
                        SceneManager.LoadScene("Mars");
                    }
                    else if (hit.collider.CompareTag("jupiter"))
                    {
                        SceneManager.LoadScene("Jupiter");
                    }
                    else if (hit.collider.CompareTag("saturn"))
                    {
                        SceneManager.LoadScene("Saturnp");
                    }
                    else if (hit.collider.CompareTag("uranus"))
                    {
                        SceneManager.LoadScene("Uranus");
                    }
                    else if (hit.collider.CompareTag("neptune"))
                    {
                        SceneManager.LoadScene("Neptune");
                    }
                    else if (hit.collider.CompareTag("pluto"))
                    {
                        SceneManager.LoadScene("Pluto");
                    }
                }
            }
        }
    }
}
