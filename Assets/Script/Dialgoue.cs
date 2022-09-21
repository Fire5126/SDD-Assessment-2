using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialgoue : MonoBehaviour
{

    #region Variables

    // hidden, global bool variable
    public static bool isInteracting;

    // Hidden local bool variable
    private bool inRange;

    // String variable with an inspector area size of 3,10
    [TextArea(3, 10)]
    public string textToShow;

    // Global gameObject variable
    public GameObject player;
    public GameObject backgroundUI;
    
    // Global TextMeshProUGUI variable
    public TextMeshProUGUI textMeshPro;

    // Hidden, Global string variable
    public static string gameObjectTag;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        isInteracting = false;
        inRange = false;
        backgroundUI.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
      

    }

    // Update is called once per frame
    void Update()
    {

        if (inRange == true)
        {
            interacting();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
        Dialgoue.gameObjectTag = gameObject.tag;

    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        gameObjectTag = null;
    }

    private void OnTriggerStay(Collider other)
    {
        Dialgoue.gameObjectTag = gameObject.tag;
    }

    private void interacting()
    {

        // If player presses E
        if (Input.GetKeyDown(KeyCode.E))
        {

            // if boolean from Raycasting script is true and bool value is false and boolean value from PauseMenu Script is false
            if (Raycasting.lookingAt == true && isInteracting == false && PauseMenu.GameisPaused == false)
            {

                // Edit the text that the textmeshpro displays
                textMeshPro.text = textToShow;

                // Set bool to true
                isInteracting = true;

                // Activate gameobject
                backgroundUI.SetActive(true);

                // Deactivate playercontroller script
                player.GetComponent<FirstPersonController>().enabled = false;

            }

            else
            {

                // Set bool to false
                isInteracting = false;

                // Deactivate gameObj
                backgroundUI.SetActive(false);

                // Activate game Controller Script
                player.GetComponent<FirstPersonController>().enabled = true;
            }

        }
        



    }
}
