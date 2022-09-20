using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{

    public LayerMask mask;
    public static bool lookingAt;
    public static bool eAnim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out var hit, 5, mask) && hit.transform.gameObject.tag == Dialgoue.gameObjectTag)
        {
            var obj = hit.collider.gameObject;

            lookingAt = true;
        }
        else
        {
            lookingAt = false;
        }

    }
}
