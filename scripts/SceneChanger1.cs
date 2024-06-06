using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanger1 : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Pslv()
    {
        SceneManager.LoadScene("PSLV");
    }
    public void Gslv()
    {
        SceneManager.LoadScene("GSLV");
    }
    public void Saturn()
    {
        SceneManager.LoadScene("Saturn");
    }
    public void Falcon()
    {
        SceneManager.LoadScene("Falcon");
    }
    public void Ariane()
    {
        SceneManager.LoadScene("Ariane");
    }
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }
} 
