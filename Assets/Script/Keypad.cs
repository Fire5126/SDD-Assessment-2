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
    public TextMeshPro displayCase;

    public Light correctLight;
    public Light incorrectLight;
    #endregion 

    #region Password
    // Sets the password combination
    public string password = "1234";
    private string userInput = "";
    #endregion

    public static bool inCollider;

    // Start is called before the first frame update
    void Start()
    {
        // At the start of the level set user's input to nothing
        userInput = "";

        // Grabs the object's animators
        otherAnimator = otherObject.GetComponent<Animator>();

        inCollider = false;
 
    }

    // Update is called once per frame
    private void Update()
    {
        displayCase.text = userInput;
    }

    public void ButtonClicked(string number)
    {
        // every button you click add the number to userInput
        userInput += number;
        // if player clicks 4 or more buttons and the 4 buttons equals the set password
        if (userInput.Length >= 4)
        {
            if (userInput == password)
            {
                otherAnimator.SetBool("Open", true);

                correctLight.color = Color.green;
                correctLight.intensity = 20;

            }
            else
            {
                //reset the input to nothing
                userInput = "";

                incorrectLight.color = Color.red;
                incorrectLight.intensity = 20;

                StartCoroutine(turnOff());

            }

        }
        

    }

    IEnumerator turnOff()
    {
        yield return new WaitForSeconds(1);

        incorrectLight.color = Color.white;

        incorrectLight.intensity = 9;

    }

    private void OnTriggerEnter(Collider other)
    {
        inCollider = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inCollider = false;
    }
}
