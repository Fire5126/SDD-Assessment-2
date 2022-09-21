using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{

    #region Variables

    // A LayerMask varaible which can be assigned in the inspector
    public LayerMask mask;

    // A boolean variable that can be used in other scripts but can't be assigned in the inspector
    public static bool lookingAt;

    // A boolean variable that can be used in other scripts but can't be assigned in the inspector
    public static bool eAnim;

    #endregion

    // Update is called once per frame
    void Update()
    {

        // An If statement that checks if a raycast hits the specific LayerMask Variable and if that gameObject tag is equal to the gameObjectTag variable in Dialgoue
        if(Physics.Raycast(transform.position, transform.forward, out var hit, 5, mask) && hit.transform.gameObject.tag == Dialgoue.gameObjectTag)
        {

            var obj = hit.collider.gameObject;

            // Set the boolean variable to true
            lookingAt = true;

        }

        else
        {

            // Set the boolean variable to false
            lookingAt = false;

        }

    }
}
