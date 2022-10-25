using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadFirstLevel()
    {
        //DontDestroyOnLoad(this);
        SceneManager.LoadScene(0);
        //SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void LoadStartScreen()
    {
        //DontDestroyOnLoad(this);
        SceneManager.LoadScene(1);
    }
}
