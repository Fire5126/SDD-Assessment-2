using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display : MonoBehaviour
{

    #region Variables

    //Hidden and local TextMeshPro Variable
    private TextMeshPro displayNum;

    // Grabbing the Keypad Script
    public Keypad script;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
        // Grab the TextMeshPro component to assign to the variable
        displayNum = GetComponent<TextMeshPro>();
    }

}
