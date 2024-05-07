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
            SceneManager.LoadSceneAsync(2);
        }
    }
}
