using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnd : MonoBehaviour
{
    private float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if(timer <= 0)
        {
            // Get the currently active scene
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Calculate the next scene index, looping back to zero if the current scene is the last one
            int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

            // Load the next scene
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
