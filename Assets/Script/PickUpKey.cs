using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    #region Variables

    // A boolean Variable that can be access in other scripts but can't be assigned in inspector
    public static bool gainedKey;

    // An invisable audioSource variable
    AudioSource audioSource;

    #endregion

    // Start is called before the first frame update
    private void Start()
    {

        //Set the boolean value to false
        gainedKey = false;

        //grabe the Audiosource component and assign it to the variable
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        // if the Variable lookingAt from the Raycasting script is true and the player presses E then run if statemet
        if (Raycasting.lookingAt == true && Input.GetKeyDown(KeyCode.E))
        {

            // Play the clip in the AudioSource
            audioSource.Play();

            // Set the boolean value to true
            gainedKey = true;

            // Destroy itself
            Destroy(gameObject);


        }
    }

    // Whenever you enter the trigger
    private void OnTriggerEnter(Collider other)
    {

        // Set the gameObject's tag that contains this script to the variable gameObjectTag in the Dialogue script
        Dialgoue.gameObjectTag = gameObject.tag;

    }

    // Whenever you exit the trigger
    private void OnTriggerExit(Collider other)
    {

        // Set the variable gameObjectTag in the Dialogue script to nothing
        Dialgoue.gameObjectTag = null;

    }

    // Whenever you stay in the trigger, run this code
    private void OnTriggerStay(Collider other)
    {

        // Set the gameObject's tag that contains this script to the variable gameObjectTag in the Dialogue script
        Dialgoue.gameObjectTag = gameObject.tag;

    }

}
