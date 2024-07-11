using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void StartGame()
    {
         SceneManager.LoadScene("Level Menu");      
    }
    public void quit()
    {
        Application.Quit();
    }
    public void custom()
    {
        //SceneManager.LoadScene("Custom Menu");

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;

    }
    public void setting()
    {
        SceneManager.LoadScene("Setting Menu");
    }

}
