using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorButton : MonoBehaviour
{

    #region Variables

    // Global interger variable
    public int colorNum = 1;

    // Global Animator Variable
    public Animator animator;

    // Global String variable
    public string pressed;

    // Global Unity Event Variable
    public UnityEvent KeypadClicked;

    #endregion

    // Start is called before the first frame
    private void Start()
    {

        // Grab the gameObject's Animator and assign it to the variable
        animator = GetComponent<Animator>();

    }

    // Whenever you click your mouse
    private void OnMouseDown()
    {

        // Activate Event
        KeypadClicked.Invoke();

        // Set animator's boolean to true
        animator.SetBool(pressed, true);

        // Start Coroutine
        StartCoroutine(anim());

    }

    IEnumerator anim()
    {

        //Wait 1 Second
        yield return new WaitForSeconds(1);

        // Set Animator's boolean to false
        animator.SetBool(pressed, false);


    }


}
