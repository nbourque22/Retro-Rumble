using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Help()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(10);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
}
