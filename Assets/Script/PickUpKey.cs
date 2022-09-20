using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public static bool gainedKey;


    // Update is called once per frame
    void Update()
    {
        if (Raycasting.lookingAt == true && Input.GetKeyDown(KeyCode.E))
        {
            gainedKey = true;

            Destroy(gameObject);


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Dialgoue.gameObjectTag = gameObject.tag;

        Debug.Log(gameObject.tag);

    }

    private void OnTriggerExit(Collider other)
    {
        Dialgoue.gameObjectTag = null;
    }

    private void OnTriggerStay(Collider other)
    {
        Dialgoue.gameObjectTag = gameObject.tag;

    }

}
