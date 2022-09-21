using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{

    #region Animation

    // Sets the different objects to activate the animators
    public GameObject otherObject;

    // Sets the animators
    Animator otherAnimator;

    #endregion

    #region Visuals

    // A TextMeshPro variable
    public TextMeshPro displayCase;

    // A Light variable
    public Light correctLight;

    // A Light Variable
    public Light incorrectLight;

    #endregion 

    #region Password

    // A string variable for the password combination
    public string password = "1234";

    // A string variable representing the user's input
    private string userInput = "";

    #endregion

    #region Sounds

    // Assignable Audio Clips
    public AudioClip doorOpening;
    public AudioClip clickSound;
    public AudioClip rightSound;
    public AudioClip wrongSound;

    // Invisiable Audiosource Variable
    AudioSource audioSource;

    #endregion

    // A boolean Variable that can be used in other scripts
    public static bool inCollider;

    // Start is called before the first frame update
    void Start()
    {

        // At the start of the level set user's input to nothing
        userInput = "";

        // Grabs the object's animators
        otherAnimator = otherObject.GetComponent<Animator>();

        // Grabs the Audiosource component 
        audioSource = GetComponent<AudioSource>();

        // Sets bool to false
        inCollider = false;
 
    }

    // Update is called once per frame
    private void Update()
    {

        // Set the TextMeshPro to the UserInput every frame
        displayCase.text = userInput;

    }

    public void ButtonClicked(string number)
    {

        // every button you click add the number to userInput
        userInput += number;

        // Play the clickSound Clip
        audioSource.PlayOneShot(clickSound);

        // if player clicks 4 or more buttons and the 4 buttons equals the set password
        if (userInput.Length >= 4)
        {

            // if the userInput equals the password
            if (userInput == password)
            {

                // Set the other object's animator's bool value "Open" to true
                otherAnimator.SetBool("Open", true);

                // Change the light of the color to green and intensity to 20
                correctLight.color = Color.green;
                correctLight.intensity = 20;

                // Play the audioClips rightSound and doorOpening
                audioSource.PlayOneShot(rightSound);

                audioSource.PlayOneShot(doorOpening);

            }

            else
            {

                //reset the input to nothing
                userInput = "";

                // Change the light of the color to red and intensity to 20
                incorrectLight.color = Color.red;
                incorrectLight.intensity = 20;

                // Play the audioClip wrongSound
                audioSource.PlayOneShot(wrongSound);

                // Go to the Coroutine
                StartCoroutine(turnOff());

            }

        }
        

    }

    IEnumerator turnOff()
    {

        // Wait for 1 second
        yield return new WaitForSeconds(1);

        //Set color to white and intensity to 9
        incorrectLight.color = Color.white;
        incorrectLight.intensity = 9;

    }

    // Whenever you enter the trigger
    private void OnTriggerEnter(Collider other)
    {

        // Set the bool variable to true
        inCollider = true;

    }

    // Whenever you exit the trigger
    private void OnTriggerExit(Collider other)
    {

        // set the bool variable to false
        inCollider = false;

    }
}
