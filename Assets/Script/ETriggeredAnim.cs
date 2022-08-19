  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ETriggeredAnim : MonoBehaviour
{

    private bool inRange;
    Animator Drawer;

    //Start is called once the game launches
    void Start()
    {
        inRange = false;
        Drawer = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true && Input.GetKeyDown("e"))
        {
            Drawer.SetBool("Open", true);
            Debug.Log("Open Sesime");
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        inRange = true;
  
    }

    private void OnTriggerExit(Collider other) 
    {
        inRange = false;
    }
}
