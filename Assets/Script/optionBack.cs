using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class optionBack : MonoBehaviour
{
    private GameObject SettingsUi;
    private GameObject Options;

    // Start is called before the first frame update
    void Start()
    {
        SettingsUi = GameObject.FindGameObjectWithTag("settingsUi");

        // gettings options 
        Options = GameObject.FindGameObjectWithTag("options");

    }


    public void back()
    {

        if (SettingsUi != null)
        {
            SettingsUi.SetActive(false);
            Options.SetActive(true);
        }

    }
}
