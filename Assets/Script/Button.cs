using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    #region Variables

    // An integer variable that can be set, used to determine which number the button is
    public int keypadNumber = 1;

    // A UnityEvent variable so that it can be referred to in other scripts and in the inspector
    public UnityEvent KeypadClicked;

    #endregion
    
    // Whenever the mouse clicks on the Button, activate the code inside
    private void OnMouseDown()
    {

        // An if statment which uses the inCollider variable from the Keypad script
        if (Keypad.inCollider == true)
        {

            // Whenever the if statement is true, invoke the event KeypadClicked
            KeypadClicked.Invoke();

        }

    }


}
