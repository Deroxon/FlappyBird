using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    private string sceneName;

    private GameObject SettingsUi;
    private GameObject Options;

    public Slider volumeSlider;
    public AudioSource audioSource;

    private void Start()
    {
        sceneName = "GameScene";
        Scene targetScene = SceneManager.GetSceneByName(sceneName);

        // gettings settings UI
        SettingsUi = GameObject.Find("SettingsUi");

        //  deactivated it immiediately
        SettingsUi.SetActive(false);

        // gettings options 
        Options = GameObject.FindGameObjectWithTag("options");

        audioSource.volume = 0.2f;

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

    public void goToSettings()
    {

        if (SettingsUi != null)
        {

            Debug.Log("options");
            SettingsUi.SetActive(true);
            Options.SetActive(false);
        }

    }


    public void changeVolume()
    {

        // changing volume in menu
        audioSource.volume = volumeSlider.value;

        // in public to change in game
        StaticNameController.globalVolume = volumeSlider.value;
    }

}
