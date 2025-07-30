using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene to load
    public void B_LoadScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    // Updated UI Elements in Unity Scenes
    public void B_QuitGame()
    {
        Application.Quit();
    }
}
