using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

/// <summary>
/// Provides universal methods for scene navigation, can be attached to the canvas (or some other hidden object) to be referenced via buttons
/// 
/// </summary>
public class ChangeScenes : MonoBehaviour
{
    public void GoToLivingRoom()
    {
        SceneManager.LoadScene("LivingRoom");
    }

    public void GoToKitchen()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void GoToFuji()
    {
        SceneManager.LoadScene("Fuji_Level");
    }

    public void GoToGreenland()
    {
        SceneManager.LoadScene("Greenland_Level");
    }

    public void GoToJupiter()
    {
        SceneManager.LoadScene("Jupiter_Level");
    }

    public void GoToSea()
    {
        SceneManager.LoadScene("Sea_Level");
    }

    public void GoToMoon()
    {
        SceneManager.LoadScene("Moonmato");
    }

    public void GoToDesktop()
    {
        Application.Quit();
    }
}
