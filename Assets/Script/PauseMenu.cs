using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    #region

    // The boolean variable that can be accessed in any script is false
    public static bool GameisPaused = false;

    // A string variable
    public string sceneToLoad;

    // A gameObject variable
    public GameObject pauseMenuUI;

    #endregion

    // Update is called once per frame
    void Update()
    {

        // Whenever player pressed the Esc key and the bool variable from Dialgoue equals to false then run this script
        if (Input.GetKeyDown(KeyCode.Escape) && Dialgoue.isInteracting == false)
        {

            // If the boolean value GameisPause is true then run this script
            if (GameisPaused)
            {

                // Go to the Sub Routine
                Resume();

            }

            else
            {

                // Go to the Sub Routine
                Pause();

            }
        }
    }
           
 


    public void Resume()
    {

        // Set the gameObject to be deActive
        pauseMenuUI.SetActive(false);

        // Set time back to normal
        Time.timeScale = 1f;

        // Set bool variable to false
        GameisPaused = false;
    }

    void Pause()
    {

        // Set the gameObject to be active
        pauseMenuUI.SetActive(true);

        // Stop time
        Time.timeScale = 0f;

        // Set the bool variable to true
        GameisPaused = true;

    }

    public void LoadMenu()
    {

        // Load the scene that corresponds with the string variable
        SceneManager.LoadScene(sceneToLoad);

        // Set time back to normal
        Time.timeScale = 1f;

    }

}
