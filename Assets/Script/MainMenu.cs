using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Public Sub Routine
    public void LoadScene()
    {

        // Load the scene that is in the next order in the buildIndex
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        // Set the bool variable from PauseMenu to false
        PauseMenu.GameisPaused = false;
    }

    // Public Sub Routine
    public void Exit()
    {

        // Quit the game
        Application.Quit();

    }
}
