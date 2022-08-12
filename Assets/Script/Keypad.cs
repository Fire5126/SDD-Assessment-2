using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{

    #region Animation
    // Sets the different objects to activate the animators
    public GameObject otherObject;
    public GameObject otherObject1;

    // Sets the animators
    Animator otherAnimator;
    Animator otherAnimator1;
    #endregion

    #region Password
    // Sets the password combination
    public string password = "1234";

    // Sets the usere's input to nothing
    private string userInput = "";
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // At the start of the level set user's input to nothing
        userInput = "";

        // Grabs the object's animators
        otherAnimator = otherObject.GetComponent<Animator>();
        otherAnimator1 = otherObject1.GetComponent<Animator>();
    }

   
    public void ButtonClicked(string number)
    {
        // every button you click add the number to userInput
        userInput += number;

        // if player clicks 4 or more buttons
        if (userInput.Length >= 4)
        {
            // if the 4 buttons the user clicked equals the set password
            if (userInput == password)
            {

                Debug.Log("Entry Allowed");
                //Trigger animation
                otherAnimator.SetBool("CorrectPass", true);
                otherAnimator1.SetBool("CorrectPass", true);
            }
            else
            {
                Debug.Log("Not this time");
                //reset the input to nothing
                userInput = "";
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
