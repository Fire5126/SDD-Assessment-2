  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ETriggeredAnim : MonoBehaviour
{

    private bool inRange;


    //Start is called once the game launches
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange = true && Input.GetKeyDown("E"))
        {
            GetComponent<Animator>().
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        inRange = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        inRange = false;
    }
}
