using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaySound : MonoBehaviour
{

    #region Sound Variables

    // An audioclip variable that can be selected in the inspector
    public AudioClip SoundToPlay;

    // An audiosource Variable that can't be selected in the inspector
    AudioSource soundSource;

    #endregion

    // Start is called before the first frame update
    void Start()
    {

        // Set the soundSource variable to the gameObject's component AudioSource
        soundSource = gameObject.GetComponent<AudioSource>();
    }

    //Whenever you enter a trigger, activate the code
    private void OnTriggerEnter(Collider other)
    {

        // Play the assigned audioclip
        soundSource.PlayOneShot(SoundToPlay);

    }
}
