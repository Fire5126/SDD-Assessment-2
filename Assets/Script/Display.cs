using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display : MonoBehaviour
{

    private TextMeshPro displayNum;
    public Keypad script;


    // Start is called before the first frame update
    void Start()
    {
        displayNum = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
