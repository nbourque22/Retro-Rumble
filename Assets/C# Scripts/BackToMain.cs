using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public AudioClip buttonClick;

    public void ButtonSound()
    {
        AudioSource.PlayClipAtPoint(buttonClick, transform.position);
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

