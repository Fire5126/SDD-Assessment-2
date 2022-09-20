using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzle : MonoBehaviour
{

    public GameObject puzzleObj;
    public Material purple;
    public Material yellow;
    public Material cyan;
    public Material white;

    public GameObject animObj;
    Animator animator;
    public string solved;

    public GameObject display1;
    public GameObject display2;
    public Material red;
    public Material blue;
    public Material green;


    private bool answer1 = false;
    private bool answer2 = false;
    private bool answer3 = false;

    private string answerInput = "";

    void Start()
    {
        animator = animObj.GetComponent<Animator>();

        answered1();
    }

    void Update()
    {
        display();
    }

    public void ButtonClicked(string number)
    {
        answerInput += number;



        if (answerInput.Length >= 2)
        {
            if (answerInput == "12" || answerInput == "21" && answer1 == false)
            {
                answered2();

            }
            else if (answerInput == "13" || answerInput == "31" && answer2 == true)
            {

                answered3();
            }
            else if (answerInput == "23" || answerInput == "32" && answer3 == true)
            {
                wait();

                answerInput = "";
                answer3 = false;

                puzzleObj.GetComponent<MeshRenderer>().material = white;

                animator.SetBool(solved, true);
            }
            else
            {
                wait();

                answerInput = "";

            }

        }


    }

    private void answered1()
    {
        wait();

        answer1 = false;
        answerInput = "";

        puzzleObj.GetComponent<MeshRenderer>().material = purple;

    }

    private void answered2()
    {
        wait();

        answer1 = true;
        answer2 = true;
        answerInput = "";

        puzzleObj.GetComponent<MeshRenderer>().material = yellow;


    }

    private void answered3()
    {
        wait();

        answer2 = false;
        answer3 = true;
        answerInput = "";

        puzzleObj.GetComponent<MeshRenderer>().material = cyan;

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);

    }

    private void display()
    {
       switch (answerInput)
        {
            case "1":

                wait();


                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = white;

                break;

            case "2":

                wait();


                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = white;

                break;

            case "3":

                wait();

                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = white;

                break;

            case "11":

                wait();

                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "12":

                wait();

                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "13":

                wait();

                display1.GetComponent<MeshRenderer>().material = red;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            case "21":

                wait();

                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "22":

                wait();

                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "23":

                wait();

                display1.GetComponent<MeshRenderer>().material = blue;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            case "31":

                wait();

                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = red;

                break;

            case "32":

                wait();

                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = blue;

                break;

            case "33":

                wait();

                display1.GetComponent<MeshRenderer>().material = green;
                display2.GetComponent<MeshRenderer>().material = green;

                break;

            default:

                wait();

                display1.GetComponent<MeshRenderer>().material = white;
                display2.GetComponent<MeshRenderer>().material = white;

                break;
        }
    }

}
