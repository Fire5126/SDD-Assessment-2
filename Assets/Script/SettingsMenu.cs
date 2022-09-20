using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    
    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public TMPro.TMP_Dropdown resolutionDropdown;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        //clears all the resolutions in the dropdown menu
        resolutionDropdown.ClearOptions();

        //create a list of strings to change into our options
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        //Loop through each element of our resolution array
        for (int i = 0; i < resolutions.Length; i++)
        {
            //create a string which displays our resolution
            string option = resolutions[i].width + " x " + resolutions[i].height;

            //add it to our option list
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        //add our option list to our resolution dropdown
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();


    }

    public void setResoultion(int resoultionIndex)
    {
        Resolution resolution = resolutions[resoultionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    public void setVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);

    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void setFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
