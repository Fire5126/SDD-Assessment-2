using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{

    public int keypadNumber = 1;

    public UnityEvent KeypadClicked;

    // Update is called once per frame
    private void Update()
    {

    }

    void OnMouseDown()
    {
        KeypadClicked.Invoke();
    }


}
