using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class KeyDoor : MonoBehaviour
{

    public string booleanValue;
    public static PickUpKey script;
    private bool inSide;

    [SerializeField] 
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        inSide = false;
    }

    private void OnTriggerEnter (Collider other)
    {
        inSide = true;
    }

    private void OnTriggerExit (Collider other)
    {
        inSide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PickUpKey.gainedKey == true && Input.GetKeyDown(KeyCode.E) && inSide == true)
        {
            anim.SetBool($"{booleanValue}", true);
        }
    }
}
