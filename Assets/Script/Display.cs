using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{

    public string Child;

    // Start is called before the first frame update
    void Start()
    {
        Transform child = transform.Find(Child);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
