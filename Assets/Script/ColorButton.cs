using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorButton : MonoBehaviour
{

    public int colorNum = 1;

    public Animator animator;
    public string pressed;

    public UnityEvent KeypadClicked;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        KeypadClicked.Invoke();

        animator.SetBool(pressed, true);

        animator.SetBool(pressed, false);

    }



}
