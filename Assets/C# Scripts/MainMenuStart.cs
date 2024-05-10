using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
{
    public AudioClip buttonClick;

    public void ButtonSound()
    {
        AudioSource.PlayClipAtPoint(buttonClick, transform.position);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ControlScreen()
    {
        SceneManager.LoadSceneAsync(10);
    }
}
