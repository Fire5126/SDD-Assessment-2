using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    // String variable
    public string nextLevel;

    // Whenever you enter the trigger
    private void OnTriggerEnter(Collider other)
    {

        // Load the scene that corresponds with the string variable
        SceneManager.LoadScene(nextLevel);

        // Set the boolean variable from the PauseMenu Script to true
        PauseMenu.GameisPaused = true;
    }

}
