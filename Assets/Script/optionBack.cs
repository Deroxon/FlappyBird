using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionBack : MonoBehaviour
{
    public GameObject SettingsUi;
    public GameObject Options;


    public void back()
    {

        if (SettingsUi != null)
        {
            SettingsUi.SetActive(false);
            Options.SetActive(true);
        }
        Debug.Log(StaticNameController.globalVolume);
    }
}
