using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    public int currentSceneIndex;
    public void OnStartPressed()
    {
        Debug.Log("Start Button Pressed!");
        SceneManager.LoadScene("Main");
    }
    public void OnNextPressed()
    {
        Debug.Log("Next Button Pressed!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnBackPressed()
    {
        Debug.Log("Back Button Pressed!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void OnQuitPressed()
    {
        Debug.Log("Quit Button Pressed!");
        SceneManager.LoadScene("Quit");
        Application.Quit();
    }
}
