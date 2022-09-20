using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialgoue : MonoBehaviour
{

    public static bool isInteracting;
    private bool inRange;
    [TextArea(3, 10)]
    public string textToShow;
    public GameObject player;
    public GameObject backgroundUI;
    public TextMeshProUGUI textMeshPro;
    public static string gameObjectTag;


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
        if (Input.GetKeyDown(KeyCode.E))
        {


            if (Raycasting.lookingAt == true && isInteracting == false && PauseMenu.GameisPaused == false)
            {
                textMeshPro.text = textToShow;
                isInteracting = true;
                backgroundUI.SetActive(true);
                player.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                isInteracting = false;
                backgroundUI.SetActive(false);
                player.GetComponent<FirstPersonController>().enabled = true;
            }

        }
        



    }
}
