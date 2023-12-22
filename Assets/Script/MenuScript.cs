using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void PLayGame()
    {
       
        Debug.Log("sceneChanged");
        SceneManager.LoadScene(SceneManager.GetSceneByName("GameScene").buildIndex);
   
    }
}
