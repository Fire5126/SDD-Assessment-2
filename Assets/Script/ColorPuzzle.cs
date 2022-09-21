using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzle : MonoBehaviour
{

    #region Puzzle Variabe

    public GameObject puzzleObj;
    public Material purple;
    public Material yellow;
    public Material cyan;
    public Material white;

    #endregion

    #region Animator Variable

    public GameObject animObj;
    Animator animator;
    public string solved;

    #endregion

    #region Display Variables

    public GameObject display1;
    public GameObject display2;
    public Material red;
    public Material blue;
    public Material green;

    #endregion

    #region Answer Variables

    private bool answer1 = false;
    private bool answer2 = false;
    private bool answer3 = false;

    #endregion

    #region Sound Variable

    public AudioClip pressed;
    public AudioClip right;
    public AudioClip wrong;
    AudioSource audioSource;

    #endregion

    private string answerInput = "";

    // Start is called before the first frame
    void Start()
    {

        // Assign gameObj's Animator to variable
        animator = animObj.GetComponent<Animator>();

        // Assign gameObj's AudioSource to Variable
        audioSource = GetComponent<AudioSource>();

        answered1();
    }

    void Update()
    {
        display();
    }

    public void ButtonClicked(string number)
    {
        // Every Number adds onto input
        answerInput += number;

        // Play Music
        audioSource.PlayOneShot(pressed);

        // Whenever answerInput has 2 or more numbers
        if (answerInput.Length >= 2)
        {
            if (answerInput == "12" && answer1 == false || answerInput == "21" && answer1 == false)
            {
                answered2();

            }
            else if (answerInput == "13" && answer2 == true || answerInput == "31" && answer2 == true)
            {

                answered3();
            }
            else if (answerInput == "23" && answer3 == true || answerInput == "32" && answer3 == true)
            {

                // Play Music
                audioSource.PlayOneShot(right);

                // Got to wait subroutine
                StartCoroutine(wait());

                // Set Boolean Values
                answer3 = false;

                // Change GameObjects material
                puzzleObj.GetComponent<MeshRenderer>().material = white;

                // Set bool value for Animator to True
                animator.SetBool(solved, true);


            }
            else
            {

                // Play Music
                audioSource.PlayOneShot(wrong);

                // Got to wait subroutine
                StartCoroutine(wait());

            }

        }


    }

    private void answered1()
    {

        // Set Boolean Values
        answer1 = false;
        answer2 = false;
        answer3 = false;

        // Change GameObjects material
        puzzleObj.GetComponent<MeshRenderer>().material = purple;



    }

    private void answered2()
    {

        // Play Music
        audioSource.PlayOneShot(right);

        // Got to wait subroutine
        StartCoroutine(wait());

        // Set Boolean Values
        answer1 = true;
        answer2 = true;
        answer3 = false;

        // Change GameObjects material
        puzzleObj.GetComponent<MeshRenderer>().material = yellow;


    }

    private void answered3()
    {

        // Play Music
        audioSource.PlayOneShot(right);

        // Got to wait subroutine
        StartCoroutine(wait());

        // Set Boolean Values
        answer2 = false;
        answer3 = true;

        // Change GameObjects material
        puzzleObj.GetComponent<MeshRenderer>().material = cyan;


    }

    IEnumerator wait()
    {

        // Wait 1 second
        yield return new WaitForSeconds(1);

        // Reset Input
        answerInput = "";
    }

    private void display()
    {

        // Case Structure representing the different types of answers
       switch (answerInput)
        {
            case "1":



                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = white;


                break;

            case "2":



                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = white;

                break;

            case "3":


                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = white;

                break;

            case "11":


                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "12":


                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "13":


                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            case "21":


                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "22":


                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "23":


                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            case "31":


                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "32":


                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "33":


                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            default:


                display1.GetComponent<MeshRenderer>().material = white;
                display2.GetComponent<MeshRenderer>().material = white;

                break;
        }
    }

}
