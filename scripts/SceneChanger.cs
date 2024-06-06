using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanger : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ApolloMission()
    {
        SceneManager.LoadScene("ApolloMission");
    }
    public void Chandrayan()
    {
        SceneManager.LoadScene("Chandrayan");
    }
    public void MoonEarth()
    {
        SceneManager.LoadScene("Moon&Earth");
    }
    public void MoonPhases()
    {
        SceneManager.LoadScene("MoonPhases");
    }
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
} 
