using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private string sceneName;
    private void Start()
    {
        sceneName = "GameScene";
        Scene targetScene = SceneManager.GetSceneByName(sceneName);

        if (targetScene.isLoaded)
        {
            Debug.Log("Scene '" + sceneName + "' is already loaded.");
        }
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void PLayGame()
    {
       
        Debug.Log("sceneChanged");
        SceneManager.LoadScene(sceneName);

    }
}
