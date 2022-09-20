  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ETriggeredAnim : MonoBehaviour
{

    private bool inRange;
    public Animator animator;
    public string parameterValue;
    //Start is called once the game launches
    void Start()
    {
        inRange = false;
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true && Input.GetKeyDown("e") && Raycasting.lookingAt == true)
        {
            animator.SetBool(parameterValue, true);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        inRange = true;
        Dialgoue.gameObjectTag = gameObject.tag;
  
    }

    private void OnTriggerStay(Collider other)
    {
        Dialgoue.gameObjectTag = gameObject.tag;

    }

    private void OnTriggerExit(Collider other) 
    {
        Dialgoue.gameObjectTag = null;
        inRange = false;
    }
}
