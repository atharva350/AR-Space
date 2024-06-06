using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanger2 : MonoBehaviour
{
    public void MainMenu()
    {
        Debug.Log("Main Menu Button Clicked");
        SceneManager.LoadScene("MainMenu");
    }
    public void Sun()
    {
        SceneManager.LoadScene("Sun");
    }
    public void Mercury()
    {
        SceneManager.LoadScene("Mercury");
    }
    public void Venus()
    {
        SceneManager.LoadScene("Venus");
    }
    public void Earth()
    {
        SceneManager.LoadScene("Earth");
    }
    public void Mars()
    {
        SceneManager.LoadScene("Mars");
    }
    public void Jupiter()
    {
        SceneManager.LoadScene("Jupiter");
    }
    public void Saturn()
    {
        SceneManager.LoadScene("Saturnp");
    }
    public void Uranus()
    {
        SceneManager.LoadScene("Uranus");
    }
    public void Neptune()
    {
        SceneManager.LoadScene("Neptune");
    }
    public void Pluto()
    {
        SceneManager.LoadScene("Pluto");
    }
    public void solar()
    {
        SceneManager.LoadScene("SolarSystem");
    }
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
} 
