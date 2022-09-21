  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ETriggeredAnim : MonoBehaviour
{

    #region

    // Hidden and local boolean variable
    private bool inRange;

    // Global animator variable
    public Animator animator;

    // Global string variable
    public string parameterValue;

    //Hidden AudioSource Variable
    AudioSource audioSource;

    #endregion

    //Start is called once the game launches
    void Start()
    {

        // Set the bool variable to false
        inRange = false;

        // Grabe the gameObject's Animator assigning it to the variable
        animator = gameObject.GetComponent<Animator>();

        // Grabe the gameObject's Audiosource assiging it to the variable
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        // If inRange is true and the player presses E and the bool variable from the Raycasting script is true then execute if statement
        if (inRange == true && Input.GetKeyDown("e") && Raycasting.lookingAt == true)
        {

            // set the bool of the animator that corresponds with the string variable to true
            animator.SetBool(parameterValue, true);

            // play the audioclip from the audiosource
            audioSource.Play();

        }
      
    }

    // Whenever you enter a trigger collider
    private void OnTriggerEnter (Collider other)
    {

        // set bool value to true
        inRange = true;

        // Set the variable from the Dialogue script to the gameObject.tag
        Dialgoue.gameObjectTag = gameObject.tag;
  
    }

    // Whenever you stay in a trigger collider
    private void OnTriggerStay(Collider other)
    {

        // Set the variable from the Dialogue script to the gameObject.tag
        Dialgoue.gameObjectTag = gameObject.tag;

    }

    // Whenever you exit a trigger collider
    private void OnTriggerExit(Collider other) 
    {

        // set bool value to false
        inRange = false;

    }
}
