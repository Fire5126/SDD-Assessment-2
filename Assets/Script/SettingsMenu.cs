using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{

    #region Variables

    // AudioMixer Variable that can be assigned in the inspector
    public AudioMixer audioMixer;

    // An array that contains resolutions
    Resolution[] resolutions;

    // A Text Mesh Pro Dropdown variable that can be assigned in the inpector
    public TMPro.TMP_Dropdown resolutionDropdown;

    #endregion

    #region Setting all the Variables
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

    #endregion

    #region Set Variables

    // Sub Routine uses integers and the computer's resoulutionIndex
    public void setResoultion(int resoultionIndex)
    {

        // Set the Resolution to the one of the resolutions in the index
        Resolution resolution = resolutions[resoultionIndex];

        // Set the screen to the specific resolutions
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }

    // Sub Routine which uses floats variable volume
    public void setVolume(float volume)
    {

        // Set the audioMixer's volume to the float
        audioMixer.SetFloat("Volume", volume);

    }

    // Sub Routine which uses the integer variable qualityIndex
    public void setQuality(int qualityIndex)
    {

        // Set the computer quality setting to the given qualityIndex
        QualitySettings.SetQualityLevel(qualityIndex);

    }

    // Sub Routine which uses boolean variable isFullscreen
    public void setFullScreen(bool isFullscreen)
    {

        // If isFullScreen is true then set the game to fullscreen
        Screen.fullScreen = isFullscreen;
    }

    #endregion
}
