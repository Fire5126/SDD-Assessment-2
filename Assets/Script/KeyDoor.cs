using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class KeyDoor : MonoBehaviour
{

    #region Variables

    // A string variable
    public string booleanValue;

    // Hidden and Local bool variable
    private bool inSide;

    // AudioSource Variable
    AudioSource opened;

    // A hidden and local Animator variable that can be seen but not edited in Inspector
    [SerializeField] 
    private Animator anim;

    #endregion

    // Start is called before the first frame update
    void Start()
    {

        // Set bool value to false
        inSide = false;

        // Set variable to the Audiosoruce component of the gameObject
        opened = GetComponent<AudioSource>();
    }

    // Whenever you enter a trigger collider
    private void OnTriggerEnter (Collider other)
    {

        // Set bool value to true
        inSide = true;

    }

    // Whenver you exit a trigger collider
    private void OnTriggerExit (Collider other)
    {

        // Set bool value to False
        inSide = false;
    }

    // Update is called once per frame
    void Update()
    {

        // If the variable from PickUpKey is true and player pressed E while inSide is true then execute if Statement
        if (PickUpKey.gainedKey == true && Input.GetKeyDown(KeyCode.E) && inSide == true)
        {

            // Play the audioclip in the AudioSource
            opened.Play();

            // Set the animator's bool that has the same name as booleanValue to true
            anim.SetBool($"{booleanValue}", true);
        }
    }
}
